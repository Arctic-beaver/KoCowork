using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Models
{
    public class MiniOfficeModel : BookingItemModel
    {
        private double _amountDays;
        public int AmountDays { get; set; }
        public string TypeForDisplayInUI = "Мини-офис";
        public int? AmountOfPlaces { get; set; }
        public List<PlaceModel> Places { get; set; }
        public decimal? PricePerDay { get; set; }

        public override void CalculateSubtotalPrice(decimal price)
        {
            _amountDays = GetAmountDays();
            SubtotalPrice = Convert.ToDecimal(_amountDays) * price;
        }
    }
}
