using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
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

        public bool CheckPayment(int id)
        {
            var order = _orderRepository.GetById(id);
            decimal realPaidSumm = 0;

            foreach (Payment payment in order.Payments)
            {
                if (payment != null) realPaidSumm += payment.Amount;
            }
            return realPaidSumm >= order.TotalPrice;
        }

        public void MarkAsPaid(int id)
        {
            Order order = _orderRepository.GetById(id);
            order.IsPaid = true;

            Update(order);
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }

        public List<OrderModel> GetAllOrders()
        {
            var orders = _orderRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<OrderModel>>(orders);
        }

        public List<OrderModel> GetCanceledOrders()
        {
            var orders = CustomMapper.GetInstance().Map<List<OrderModel>>(_orderRepository.GetAll());
            var result = new List<OrderModel>();
            foreach (var order in orders)
            {
                if (order.IsCanceled)
                {
                    result.Add(order);
                }
            }
            return result;
        }

        public List<OrderModel> GetPaidOrders()
        {
            var orders = CustomMapper.GetInstance().Map<List<OrderModel>>(_orderRepository.GetAll());
            var result = new List<OrderModel>();
            foreach (var order in orders)
            {
                if (order.IsPaid && !order.IsCanceled)
                {
                    result.Add(order);
                }
            }
            return result;
        }

        public List<OrderModel> GetUnpaidOrders()
        {
            var orders = CustomMapper.GetInstance().Map<List<OrderModel>>(_orderRepository.GetAll());
            var result = new List<OrderModel>();
            foreach (var order in orders)
            {
                if (!order.IsPaid && !order.IsCanceled)
                {
                    result.Add(order);
                }
            }
            return result;
        }


        public List<OrderModel> GetActiveOrders()
        {
            var orders = CustomMapper.GetInstance().Map<List<OrderModel>>(_orderRepository.GetAll());
            var result = new List<OrderModel>();

            return result;
        }

        public void UpdateOrder(OrderModel orderModel)
        {
            Order order = CustomMapper.GetInstance().Map<Order>(orderModel);
            _orderRepository.Update(order);
        }

        public Order InsertOrder(OrderModel orderModel)
        {
            _order = CustomMapper.GetInstance().Map<Order>(orderModel);
            _order.ClientId = _clientService.FindClientInDB(orderModel.Client).Id;
            var idOrder = _orderRepository.Add(_order);
            _order.Id = idOrder;

            return _order;
        }
    }
}

