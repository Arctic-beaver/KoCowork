<<<<<<< HEAD
﻿using CoCowork.DataLayer.Entities;
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
        public int CreateNewOrder(Client client, bool isCancelled, bool isPaid, int totalPrice)
        {
            var newOrder = new Order { Client = client, IsCancelled = isCancelled, IsPaid = isPaid, TotalPrice = totalPrice };
            var newOrderRepository = new OrderRepository();
            var idOrder = newOrderRepository.Add(newOrder);
            return idOrder;
        }

    }
}

