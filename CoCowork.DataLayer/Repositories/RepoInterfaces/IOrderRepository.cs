using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IOrderRepository
    {
        void Add(Order order);
        void Delete(int id);
        List<Order> GetAll();
        Order GetById(int id);
        void Update(Order order);
    }
}