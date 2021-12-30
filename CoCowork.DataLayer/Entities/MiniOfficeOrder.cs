using System;

namespace CoCowork.DataLayer.Entities
{
    public class MiniOfficeOrder : BookingBaseOrder
    {
        public MiniOffice MiniOffice { get; set; }
        private double _amountDays;


        public override void CalculateSubtotalPrice(decimal price)
        {
            _amountDays = GetAmountDays();
            SubtotalPrice = Convert.ToDecimal(_amountDays) * price;
        }


    }
}
