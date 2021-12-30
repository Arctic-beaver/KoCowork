using CoCowork.DataLayer.Entities;
using System;

namespace CoCowork.BusinessLayer.Models
{
    public abstract class ItemModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public BookingChecker BookingChecker { get; set; }
        public decimal Price { get; set; }

        public abstract void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price);
    }
}
