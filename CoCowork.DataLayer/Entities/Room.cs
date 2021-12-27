using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Entities
{
    public class Room
    {
        public int Id { get;  }
        public string Type { get; set; }
        public int AmountOfPeople { get; set; }
        public decimal PricePerHour { get; set; }
        public string Description { get; set; }
    }
}
