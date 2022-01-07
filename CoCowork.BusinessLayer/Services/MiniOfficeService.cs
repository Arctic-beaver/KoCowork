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
        private OrderRepository _orderRepository;
        public MiniOfficeService()
        {
            _miniOfficeRepository = new MiniOfficeRepository();
            _placeRepository = new PlaceRepository();
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
            return _miniOfficeRepository.DeleteMiniOfficeById(miniOffice.Id);
        }

        public void UpdateMiniOffice(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            _miniOfficeRepository.UpdateMiniOffice(mOffice);
        }

        public int InsertMiniOfficeWithPlaces(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);

            foreach (var placeEntity in miniOffice.Places)
            {
                var place = CustomMapper.GetInstance().Map<Place>(placeEntity);
                _placeRepository.Add(place);
            }

            return _miniOfficeRepository.Add(mOffice);
        }

        public void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            var _entity = _miniOfficeRepository.GetAll().Find(x => x.Id == id);

            var itemOrder = new MiniOfficeOrder { MiniOffice = _entity, Order = order, StartDate = startDate, EndDate = endDate };
            //_itemOrder.CalculateSubtotalPrice(price);

            _orderRepository.Add(itemOrder);
        }
    }
}
