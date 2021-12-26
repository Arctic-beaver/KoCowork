using System;

namespace CoCowork.DataLayer.Entities
{
    public class PlaceOrder : IOrder
    {
        public int Id { get; set; }
        public Place Place { get; set; }
        public Order Order { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal SubtotalPrice { get; set; }
    }
}
