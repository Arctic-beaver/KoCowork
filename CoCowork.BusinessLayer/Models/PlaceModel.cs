using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;

namespace CoCowork.BusinessLayer.Models
{
    public class PlaceModel : ItemModel
    {
        public string Name { get; set; }
        public bool IsFixed { get; set; }
        public int AmountDays { get; set; }
        public string TypeForDisplayInUI = "Место";
        public int Number { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PriceFixedPerDay { get; set; }
        public string Description { get; set; }

        private PlaceRepository _repository;
        private Place _entitie;
        private PlaceOrder _itemOrder;
        private PlaceOrderRepository _orderRepository;

        public PlaceModel()
        {
            _repository = new PlaceRepository();
            _orderRepository = new PlaceOrderRepository();
        }

        public override void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            _entitie = _repository.GetAll().Find(x => x.Id == id);

            _itemOrder = new PlaceOrder { Place = _entitie, Order = order, StartDate = startDate, EndDate = endDate };
            _itemOrder.CalculateSubtotalPrice(price);

            _orderRepository.Add(_itemOrder);
        }

    }
}