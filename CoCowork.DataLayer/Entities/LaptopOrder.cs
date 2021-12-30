using System;


namespace CoCowork.DataLayer.Entities
{
    public class LaptopOrder : BookingBaseOrder
    {
        public Laptop Laptop { get; set; }
        private double _amountMonths;

        public override void CalculateSubtotalPrice(decimal price)
        {
            _amountMonths = GetAmountMonth();
            SubtotalPrice = Convert.ToDecimal(_amountMonths) * price;
        }


    }
}
