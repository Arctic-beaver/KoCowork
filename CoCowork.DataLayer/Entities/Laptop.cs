﻿

namespace CoCowork.DataLayer.Entities
{
    public class Laptop
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Amount { get; set; }
        public decimal PricePerMonth { get; set; }
        public string Description { get; set; }
    }
}
