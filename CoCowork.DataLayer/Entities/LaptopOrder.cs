﻿using System;


namespace CoCowork.DataLayer.Entities
{
    public class LaptopOrder
    {
        public int Id { get; set; }
        public Laptop Laptop { get; set; }
        public int OrderId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal SubtotalPrice { get; set; }
    }
}
