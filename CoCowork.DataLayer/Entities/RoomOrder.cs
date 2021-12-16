using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Entities
{
    public class RoomOrder
    {
        public int Id { get;  }
        public Room RoomId { get; set; }
        public Order OrderId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal SubtotalPrice { get; set; }

    }
}
