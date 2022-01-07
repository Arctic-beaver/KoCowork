using System;

namespace CoCowork.DataLayer.Entities
{
    public class PlaceOrder : BookingBaseOrder
    {
        public Place Place { get; set; }
        public int ClientId { get; set; }
        private double _amountDays;

        //public override void CalculateSubtotalPrice(decimal price)
        //{
        //    _amountDays = GetAmountDays();
        //    SubtotalPrice = Convert.ToDecimal(_amountDays) * price;
        //}


    }
}
