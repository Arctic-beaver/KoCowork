using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public interface IOrderService
    {
        Order InsertOrder(Client client, bool isCanceled, bool isPaid, decimal totalPrice);
        List<OrderModel> GetActiveOrders();
        List<OrderModel> GetAllOrders();
        List<OrderModel> GetCanceledOrders();
        List<OrderModel> GetPaidOrders();
        List<OrderModel> GetUnpaidOrders();
        void UpdateOrder(OrderModel orderModel);
    }
}