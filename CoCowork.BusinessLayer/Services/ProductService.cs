using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using PseudoCalc.BusinessLayer.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public List<ProductModel> GetAllOrders()
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
    }
}
