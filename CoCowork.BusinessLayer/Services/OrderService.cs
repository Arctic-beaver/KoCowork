using CoCowork.BusinessLayer.Models;
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
    }
}
