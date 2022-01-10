using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Models
{
    public class MiniOfficeModel : BookingItemModel
    {
        private double _amountDays;
        public int AmountDays { get; set; }
        public int? AmountOfPlaces { get; set; }
        public List<PlaceModel> Places { get; set; }
        public decimal? PricePerDay { get; set; }

        public MiniOfficeModel()
        {
            TypeForDisplayInUI = "Мини-офис";
        }

        public override void CalculateSubtotalPrice()
        {
            _amountDays = GetAmountDays();
            SubtotalPrice = Convert.ToDecimal(_amountDays) * PricePerDay;
        }

       
    }
}
