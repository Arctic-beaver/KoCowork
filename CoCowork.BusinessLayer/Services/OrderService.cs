using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;

namespace CoCowork.BusinessLayer.Services
{
    public class OrderService
    {


        public Order AddedOrderToDB(Client client, bool isCancelled, bool isPaid, decimal totalPrice)
        {
            var newOrder = new Order { Client = client, IsCancelled = isCancelled, IsPaid = isPaid, TotalPrice = totalPrice };
            var newOrderRepository = new OrderRepository();
            var idOrder = newOrderRepository.Add(newOrder);
            newOrder.Id = idOrder;
            return newOrder;
        }



    }
}

