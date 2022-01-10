﻿

using System;

namespace CoCowork.BusinessLayer.Models
{
    public class PlaceModel : BookingItemModel
    {
        private double _amountDays;
        public int? Number { get; set; }
        public bool IsFixed { get; set; }
        public int AmountDays { get; set; }
        public string TypeForDisplayInUI = "Место";
        public decimal? PricePerDay { get; set; }
        public decimal? PriceFixedPerDay { get; set; }
        public int? MiniOfficeId { get; set; }

        public override void CalculateSubtotalPrice()
        {
            _amountDays = GetAmountDays();
            if (IsFixed)
            {
                SubtotalPrice = Convert.ToDecimal(_amountDays) * PriceFixedPerDay;
            }
            else
            {
                SubtotalPrice = Convert.ToDecimal(_amountDays) * PricePerDay;

            }
        }

       
    }
}