using System;

namespace CoCowork.DataLayer.Entities
{
    public class PlaceOrder : BaseOrder
    {
        public Place Place { get; set; }
        public Order Order { get; set; }
        public int ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
