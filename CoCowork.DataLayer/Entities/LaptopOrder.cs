using System;


namespace CoCowork.DataLayer.Entities
{
    public class LaptopOrder : BaseOrder
    {
        public Laptop Laptop { get; set; }
        public Order Order { get; set; } // make Order order once merge with main
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
