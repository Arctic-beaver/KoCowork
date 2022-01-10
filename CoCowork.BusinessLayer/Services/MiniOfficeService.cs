using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class MiniOfficeService : IMiniOfficeService, IItemService
    {
        private readonly IMiniOfficeRepository _miniOfficeRepository;
        private readonly IPlaceRepository _placeRepository;
        private IMiniOfficeOrderRepository _orderRepository;
        private MiniOfficeOrder _itemOrder;

        public MiniOfficeService()
        {
            _miniOfficeRepository = new MiniOfficeRepository();
            _placeRepository = new PlaceRepository();
            _orderRepository = new MiniOfficeOrderRepository();
        }

        public MiniOfficeService(IMiniOfficeOrderRepository fakeMiniOfficeOrderRepository)
        {
            _orderRepository = fakeMiniOfficeOrderRepository;
            _miniOfficeRepository = new MiniOfficeRepository();
        }

        public MiniOfficeService(IMiniOfficeRepository fakeMiniOfficeRepository, IPlaceRepository fakePlaceRepository)
        {
            _miniOfficeRepository = fakeMiniOfficeRepository;
            _placeRepository = fakePlaceRepository;
        }

        public List<MiniOfficeModel> GetAll()
        {
            var miniOffices = _miniOfficeRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<MiniOfficeModel>>(miniOffices);
        }

        public bool DeleteMiniOffice(MiniOfficeModel miniOffice)
        {
            try
            {
                _miniOfficeRepository.DeleteMiniOffice(miniOffice.Id);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void UpdateMiniOffice(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            _miniOfficeRepository.UpdateMiniOffice(mOffice);
        }

        public int InsertMiniOfficeWithPlaces(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            int insertedMiniOfficeId = 0;

            try
            {
                insertedMiniOfficeId = _miniOfficeRepository.Add(mOffice);
            }
            catch (Exception)
            {
                return -1;
            }

            foreach (var placeEntity in miniOffice.Places)
            {
                var place = CustomMapper.GetInstance().Map<Place>(placeEntity);
                place.MiniOfficeId = insertedMiniOfficeId;

                try
                {
                    _placeRepository.Add(place);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return insertedMiniOfficeId;
        }

        public void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            var _entity = _miniOfficeRepository.GetMiniOfficeById(id);

            var itemOrder = new MiniOfficeOrder { MiniOffice = _entity, Order = order, StartDate = startDate, EndDate = endDate, };

            _orderRepository.Add(itemOrder);
        }

        public void DeleteMiniOffice(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertMiniOffice(MiniOfficeModel miniOffice)
        {
            throw new NotImplementedException();
        }

        public int AddItemOrder(ItemModel bookingItem)
        {
            throw new NotImplementedException();
        }

        public int AddItemOrder(BookingItemModel bookingItem)
        {
            var _entity = _miniOfficeRepository.GetMiniOfficeById(bookingItem.Id);

            _itemOrder = new MiniOfficeOrder { MiniOffice = _entity, Order = bookingItem.Order, StartDate = bookingItem.StartDate, EndDate = bookingItem.EndDate, SubtotalPrice = bookingItem.SubtotalPrice };

            return _orderRepository.Add(_itemOrder);
        }
    }
}
