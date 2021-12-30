using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Models
{
    public class MiniOfficeModel : ItemModel
    {
        public string Name { get; set; }
        public int AmountDays { get; set; }
        public string TypeForDisplayInUI = "Мини-офис";
        public int AmountOfPlaces { get; set; }
        public List<PlaceModel> Places { get; set; }

        private MiniOfficeRepository _repository;
        private MiniOffice _entitie;
        private MiniOfficeOrder _itemOrder;
        private MiniOfficeOrderRepository _orderRepository;

        public MiniOfficeModel()
        {
            _repository = new MiniOfficeRepository();
            _orderRepository = new MiniOfficeOrderRepository();
        }

        public override void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            _entitie = _repository.GetAll().Find(x => x.Id == id);

            _itemOrder = new MiniOfficeOrder { MiniOffice = _entitie, Order = order, StartDate = startDate, EndDate = endDate };
            _itemOrder.CalculateSubtotalPrice(price);

            _orderRepository.Add(_itemOrder);
        }
    }
}
