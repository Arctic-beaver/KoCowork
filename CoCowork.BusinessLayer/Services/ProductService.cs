using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using PseudoCalc.BusinessLayer.Configuration;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    internal class ProductService
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

        public Product ConvertModelToEntities(ProductModel Product)
        {
            return CustomMapper.GetInstance().Map<Product>(Product);
        }
    }
}

