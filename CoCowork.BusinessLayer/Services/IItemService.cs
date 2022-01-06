using CoCowork.DataLayer.Entities;
using System;

namespace CoCowork.BusinessLayer.Services
{
    interface IItemService
    {
        void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price);

    }
}
