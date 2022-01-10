using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IProductRepository
    {
        int Add(Product product);
        void Delete(int id);
        List<Product> GetAll();
        Product GetById(int id);
        void Update(Product product);
    }
}