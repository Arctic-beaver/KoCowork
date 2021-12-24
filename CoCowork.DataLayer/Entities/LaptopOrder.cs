using System;


namespace CoCowork.DataLayer.Entities
{
    public class LaptopOrder : IOrder
    {
        public int Id { get; set; }
        public Laptop Laptop { get; set; }
        public Order Order { get; set; } // make Order order once merge with main
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal SubtotalPrice { get; set; }
    }
}
