using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI
{
    public class PlaceTest
    {
        public decimal PricePerDay { get; set; }
        public decimal? FixedPricePerDay { get; set; }
        public int Number { get; set; }
        public string Type { get; } = "Место";
    }
}
