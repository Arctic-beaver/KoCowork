using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IPlaceOrderRepository
    {
        void Add(PlaceOrder placeOrder);
        void DeletePlaceOrderById(int id);
        List<PlaceOrder> GetAllPlaceOrders();
        PlaceOrder GetPlaceOrderById(int id);
        List<PlaceOrder> GetPlaceOrdersReferToOrder(int orderId);
        List<PlaceOrder> GetPlaceOrdersReferToOrder(Order order);
        void UpdatePlaceOrderById(PlaceOrder placeOrder);
    }
}