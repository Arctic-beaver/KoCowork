using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IMiniOfficeOrderRepository
    {
        void Add(MiniOfficeOrder miniOfficeOrder);
        void DeleteMiniOfficeOrderById(int id);
        List<MiniOfficeOrder> GetAllMiniOfficeOrders();
        MiniOfficeOrder GetMiniOfficeOrderById(int id);
        List<MiniOfficeOrder> GetMiniOfficeOrdersReferToOrder(int orderId);
        List<MiniOfficeOrder> GetMiniOfficeOrdersReferToOrder(Order order);
        void UpdateMiniOfficeOrderById(MiniOfficeOrder miniOfficeOrder);
    }
}