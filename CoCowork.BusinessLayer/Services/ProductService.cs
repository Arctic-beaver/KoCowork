﻿using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class ProductService : IProductService, IItemService
    {
        private readonly IProductRepository _productRepository;
        private ProductOrder _itemOrder;
        private IProductOrderRepository _orderRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
            _orderRepository = new ProductOrderRepository();

        }
        public ProductService(IProductOrderRepository fakeProductOrderRepository)
        {
            _orderRepository = fakeProductOrderRepository;
            _productRepository = new ProductRepository();

        }
        public int AddItemOrder(ItemModel bookingItem)
        {

            var _entity = _productRepository.GetById(bookingItem.Id);

            _itemOrder = new ProductOrder { Product = _entity, Order = bookingItem.Order, SubtotalPrice = bookingItem.SubtotalPrice};

            return _orderRepository.Add(_itemOrder);
        }

        public int AddItemOrder(BookingItemModel bookingItem)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAll()
        {
            var Products = _productRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<ProductModel>>(Products);
        }

        public List<ProductModel> GetAll()
        {
            var products = _productRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<ProductModel>>(products);
        }

        public List<ProductModel> GetProductsInStock()
        {
            var products = CustomMapper.GetInstance().Map<List<ProductModel>>(_productRepository.GetAll());
            var result = new List<ProductModel>();
            foreach (var product in products)
            {
                if (product.Amount!=0)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        public void UpdateProduct(ProductModel productModel)
        {
            Product product = CustomMapper.GetInstance().Map<Product>(productModel);
            _productRepository.Update(product);
        }

        public string AddProduct(ProductModel productModel)
        {
            Product product = CustomMapper.GetInstance().Map<Product>(productModel);
            string result = string.Empty;
            try
            {
                _productRepository.Add(product);
                result = "Успех";
            }
            catch(Exception ex)
            {
                result = ex.Message; 
            }
            return result;
            
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
        }
    }
}
