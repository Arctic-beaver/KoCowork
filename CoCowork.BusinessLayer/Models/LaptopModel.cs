using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;

namespace CoCowork.BusinessLayer.Models
{
    public class LaptopModel : ItemModel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal PricePerMonth { get; set; }
        public string Description { get; set; }
        public string TypeForDisplayInUI = "Ноутбук";
        public int AmountMonth { get; set; }

        private LaptopRepository _repository;
        private Laptop _entitie;
        private LaptopOrder _itemOrder;
        private LaptopOrderRepository _orderRepository;

        public LaptopModel()
        {
            _repository = new LaptopRepository();
            _orderRepository = new LaptopOrderRepository();
        }

        public override void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            _entitie = _repository.GetAll().Find(x => x.Id == id);

            _itemOrder = new LaptopOrder { Laptop = _entitie, Order = order, StartDate = startDate, EndDate = endDate };
            _itemOrder.CalculateSubtotalPrice(price);

            _orderRepository.Add(_itemOrder);
        }
    }
}
