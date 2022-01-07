using System;

namespace CoCowork.DataLayer.Entities
{
    public class RoomOrder : BaseOrder
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Room Room { get; set; }

    }
}
