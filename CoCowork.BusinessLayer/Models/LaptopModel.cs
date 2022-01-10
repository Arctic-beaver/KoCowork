﻿using System;

namespace CoCowork.BusinessLayer.Models
{
    public class LaptopModel : BookingItemModel
    {
        private double _amountMonths;
        public int Number { get; set; }
        public decimal PricePerMonth { get; set; }
        public int AmountMonth { get; set; }

        public LaptopModel()
        {
            TypeForDisplayInUI = "Ноутбук";
        }

        public override void CalculateSubtotalPrice(decimal price)
        {
            _amountMonths = GetAmountMonth();
            SubtotalPrice = Convert.ToDecimal(_amountMonths) * price;
        }

        public override void CalculateAmountOfBookingTime()
        {
            throw new NotImplementedException();
        }
    }
}
