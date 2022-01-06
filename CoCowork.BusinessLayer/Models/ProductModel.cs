using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;

namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : ItemModel
    {
        private ProductRepository _repository;
        public string TypeForDisplayInUI = "Продукты";

        public ProductModel()
        {
            _repository = new ProductRepository();
        }

        
    }
}
