﻿using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using PseudoCalc.BusinessLayer.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
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
                if (order.IsCancelled == true)
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
                if (order.IsPaid == true)
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
                if (order.IsPaid == false)
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
    }
}
