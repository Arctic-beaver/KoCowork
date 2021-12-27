using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface ILaptopOrderRepository
    {
        void Add(LaptopOrder laptopOrder);
        void DeleteLaptopOrderById(int id);
        List<LaptopOrder> GetAllLaptopOrders();
        LaptopOrder GetLaptopOrderById(int id);
        List<LaptopOrder> GetLaptopOrderByOrderId(int orderId);
        void UpdateMiniOfficeOrderById(LaptopOrder laptopOrder);
    }
}