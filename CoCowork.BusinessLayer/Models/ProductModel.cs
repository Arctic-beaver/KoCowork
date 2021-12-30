using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;

namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : ItemModel
    {
        public string Name { get; set; }
        public string TypeForDisplayInUI = "Продукты";
        
        private ProductRepository _repository;
        private Product _entitie;
        private ProductOrder _itemOrder;
        private ProductOrderRepository _orderRepository;

        public ProductModel()
        {
            _repository = new ProductRepository();
            _orderRepository = new ProductOrderRepository();
        }

        public override void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            _entitie = _repository.GetAll().Find(x => x.Id == id);

            _itemOrder = new ProductOrder { Product = _entitie, Order = order, SubtotalPrice = price};

            _orderRepository.Add(_itemOrder);
        }
    }
}
