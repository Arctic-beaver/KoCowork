using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        private Order _order;
        private ClientService _clientService;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
            _clientService = new ClientService();
        }

        public OrderService(IOrderRepository fakeOrderRepository)
        {
            _orderRepository = fakeOrderRepository;
            _clientService = new ClientService();

        }

        public bool CheckPayment(int orderId)
        {
            var order = _orderRepository.GetById(orderId);
            return order.IsPaid;
        }

        public void MarkAsPaidIfNeeded(int orderId)
        {
            var order = _orderRepository.GetById(orderId);
            decimal realPaidSumm = 0;

            foreach (Payment payment in order.Payments)
            {
                if (payment != null) realPaidSumm += payment.Amount;
            }

            if (realPaidSumm >= order.TotalPrice)
            {
                order.IsPaid = true;
                UpdateOrder(order);
            }
        }

        public List<OrderModel> GetAllOrders()
        {
            var orders = _orderRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<OrderModel>>(orders);
        }

        public List<OrderModel> GetSpecialOrders(bool isPaid, bool isUnpaid, bool isCancelled)
        {
            var orders = GetAllOrders();
            var result = new List<OrderModel>();
            foreach (var order in orders)
            {
                if ((order.IsPaid == isPaid || !order.IsPaid == isUnpaid) && (order.IsCanceled == isCancelled || !order.IsCanceled))
                {
                    result.Add(order);
                }
            }
            return result;
        }

        public List<OrderModel> GetActiveOrders()
        {
            throw new NotImplementedException();
        } 

        public void UpdateOrder(OrderModel orderModel)
        {
            Order order = CustomMapper.GetInstance().Map<Order>(orderModel);
            UpdateOrder(order);
        }

        public Order InsertOrder(OrderModel orderModel)
        {
            _order = CustomMapper.GetInstance().Map<Order>(orderModel);
            //_order.ClientId = _clientService.FindClientInDB(orderModel.Client).Id;
            var idOrder = _orderRepository.Add(_order);
            _order.Id = idOrder;

            return _order;
        }

        private void UpdateOrder(Order order)
        {
            _orderRepository.Update(order);
        }
    }
}

