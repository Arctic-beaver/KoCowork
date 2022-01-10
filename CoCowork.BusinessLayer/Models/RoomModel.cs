using System;

namespace CoCowork.BusinessLayer.Models
{
    public class RoomModel : BookingItemModel
    {
        public string Type { get; set; }
        public int AmountOfPeople { get; set; }
        public decimal PricePerHour { get; set; }
        public int AmountHours { get; set; }
        public string TypeForDisplayInUI = "Комната";

        public override void CalculateSubtotalPrice()
        {
            SubtotalPrice = Convert.ToDecimal(GetAmountHours()) * PricePerHour;
        }

      
    }
}