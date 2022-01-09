﻿namespace CoCowork.BusinessLayer.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public ClientModel Client { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsPaid { get; set; }
        public bool IsCancelled { get; set; }
    }
}
