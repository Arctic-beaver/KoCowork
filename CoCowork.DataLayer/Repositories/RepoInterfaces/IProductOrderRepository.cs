using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IProductOrderRepository
    {
        int Add(ProductOrder productorder);
        void Delete(int id);
        List<ProductOrder> GetAll();
        ProductOrder GetById(int id);
        void Update(ProductOrder productorder);
    }
}