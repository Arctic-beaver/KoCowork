﻿using System;

namespace CoCowork.BusinessLayer.Models
{
    public class RoomModel : BookingItemModel
    {
        public string Type { get; set; }
        public int AmountOfPeople { get; set; }
        public decimal PricePerHour { get; set; }
        public int AmountHours { get; set; }

        public RoomModel()
        {
            TypeForDisplayInUI = "Комната";
        }

        public override void CalculateSubtotalPrice(decimal price)
        {
            SubtotalPrice = Convert.ToDecimal(GetAmountHours()) * price;
        }

        public override void CalculateAmountOfBookingTime()
        {
            throw new NotImplementedException();
        }
    }
}