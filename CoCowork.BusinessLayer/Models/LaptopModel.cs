using System;

namespace CoCowork.BusinessLayer.Models
{
    public class LaptopModel : BookingItemModel
    {
        private double _amountMonths;
        public int? Number { get; set; }
        public int? Amount { get; set; }
        public decimal? PricePerMonth { get; set; }
        public string TypeForDisplayInUI = "Ноутбук";
        public int? AmountMonth { get; set; }

        public override void CalculateSubtotalPrice(decimal price)
        {
            _amountMonths = GetAmountMonth();
            SubtotalPrice = Convert.ToDecimal(_amountMonths) * price;
        }
    }
}
