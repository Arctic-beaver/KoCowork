using System;

namespace CoCowork.DataLayer.Entities
{
    public class RoomOrder : BaseOrder
    {
        public Room Room { get; set; }
        public Order Order { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
