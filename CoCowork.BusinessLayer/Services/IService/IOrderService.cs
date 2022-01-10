using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public interface IOrderService
    {
        Order InsertOrder(OrderModel orderModel);
        List<OrderModel> GetActiveOrders();
        List<OrderModel> GetAllOrders();
        List<OrderModel> GetSpecialOrders(bool isPaid, bool isUnpaid, bool isCancelled);
        bool CheckPayment(int orderId);
        void MarkAsPaidIfNeeded(int orderId);
        void UpdateOrder(OrderModel orderModel);
    }
}