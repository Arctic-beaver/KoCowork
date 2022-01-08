using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public bool CheckPayment(int id)
        {
            var order = _orderRepository.GetById(id);
            decimal realPaidSumm = 0;
            foreach (Payment payment in order.Payments)
            {
                realPaidSumm += payment.Amount;
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
                if (order.IsCancelled)
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
                if (order.IsPaid)
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
                if (!order.IsPaid)
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
            //foreach (var order in orders)
            //{
            //    if (order. == true)
            //    {
            //        result.Add(order);
            //    }
            //}
            return result;
        }

        public void UpdateOrder(OrderModel orderModel)
        {
            Order order = CustomMapper.GetInstance().Map<Order>(orderModel);
            _orderRepository.Update(order);
        }
    }
}
