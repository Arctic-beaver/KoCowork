using System;

namespace CoCowork.DataLayer.Entities
{
    public class PlaceOrder : BaseOrder
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Place Place { get; set; }
        public int ClientId { get; set; }
        private double _amountDays;



    }
}
