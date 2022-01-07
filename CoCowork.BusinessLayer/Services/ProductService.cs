using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    internal class ProductService : IProductService, IItemService
    {
        private readonly ProductRepository _productRepository;
        private ProductOrder _itemOrder;
        private ProductOrderRepository _orderRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
            _orderRepository = new ProductOrderRepository();

        }

        public void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            var _entity = _productRepository.GetById(id);

            _itemOrder = new ProductOrder { Product = _entity, Order = order, SubtotalPrice = price };

            _orderRepository.Add(_itemOrder);
        }

        public List<ProductModel> GetAll()
        {
            var Products = _productRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<ProductModel>>(Products);
        }


    }
}

