using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class PlaceService : IPlaceService, IItemService
    {
        private readonly IPlaceRepository _placeRepository;
        private PlaceOrder _itemOrder;
        private IPlaceOrderRepository _orderRepository;

        public PlaceService()
        {
            _placeRepository = new PlaceRepository();
        }

        public PlaceService(IPlaceOrderRepository fakePlaceOrderRepository)
        {
            _orderRepository = fakePlaceOrderRepository;
            _placeRepository = new PlaceRepository();

        }

        public List<PlaceModel> GetAll()
        {
            var places = _placeRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<PlaceModel>>(places);
        }

        public List<PlaceModel> GetAllThatNotInMiniOffices()
        {
            var places = _placeRepository.GetPlacesThatNotInMiniOffice();
            return CustomMapper.GetInstance().Map<List<PlaceModel>>(places);
        }

        public bool DeletePlace(int id)
        {
            try
            {
                _placeRepository.DeletePlaceById(id);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void UpdatePlace(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            _placeRepository.UpdatePlaceById(placeModel);
        }

        public int InsertPlace(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            int insertedPlaceId = 0;

            try
            {
                insertedPlaceId = _placeRepository.Add(placeModel);
            }
            catch (Exception)
            {
                return -1;
            }
            return insertedPlaceId;
        }

        
        void IPlaceService.InsertPlace(PlaceModel place)
        {
            throw new NotImplementedException();
        }

        public int AddItemOrder(ItemModel bookingItem)
        {
            throw new NotImplementedException();
        }

        public int AddItemOrder(BookingItemModel bookingItem)
        {
            var _entity = _placeRepository.GetPlaceById(bookingItem.Id);

            _itemOrder = new PlaceOrder { Place = _entity, Order = bookingItem.Order, StartDate = bookingItem.StartDate, EndDate = bookingItem.EndDate};

            return _orderRepository.Add(_itemOrder);
        }

        void IPlaceService.DeletePlace(int id)
        {
            throw new NotImplementedException();
        }
    }
}

