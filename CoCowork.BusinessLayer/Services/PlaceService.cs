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
        private PlaceOrderRepository _orderRepository;

        public PlaceService()
        {
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

        public void DeletePlace(int id)
        {
            _placeRepository.DeletePlaceById(id);
        }

        public void UpdatePlace(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            _placeRepository.UpdatePlaceById(placeModel);
        }

        public void InsertPlace(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            _placeRepository.Add(placeModel);
        }

        public void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            var _entity = _placeRepository.GetAll().Find(x => x.Id == id);

            _itemOrder = new PlaceOrder { Place = _entity, Order = order, StartDate = startDate, EndDate = endDate };
            _itemOrder.CalculateSubtotalPrice(price);

            _orderRepository.Add(_itemOrder);
        }
    }
}

