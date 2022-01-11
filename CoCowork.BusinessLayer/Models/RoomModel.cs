using CoCowork.BusinessLayer.Services;
using System;

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
            ItemService = new RoomService();

        }

        public override void CalculateSubtotalPrice()
        {
            SubtotalPrice = Convert.ToDecimal(GetAmountHours()) * PricePerHour;
        }

      
    }
}