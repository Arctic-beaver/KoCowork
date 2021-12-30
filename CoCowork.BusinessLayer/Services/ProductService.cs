﻿using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Repositories;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    internal class ProductService : IProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public List<ProductModel> GetAll()
        {
            var Products = _productRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<ProductModel>>(Products);
        }


    }
}

