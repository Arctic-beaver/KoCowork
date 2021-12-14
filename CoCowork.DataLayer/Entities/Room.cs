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
        public int Type { get; set; }
        public int AmountOfPeople { get; set; }
        public int PricePerHour { get; set; }

    }
}
