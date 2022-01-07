using System;

namespace CoCowork.DataLayer.Entities
{
    public class RoomOrder : BookingBaseOrder
    {
        public Room Room { get; set; }

        //public override void CalculateSubtotalPrice(decimal price)
        //{
        //    SubtotalPrice = Convert.ToDecimal(GetAmountHours()) * price;
        //}
    }
}
