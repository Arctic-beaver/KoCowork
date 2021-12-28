using CoCowork.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class LaptopModel : ItemModel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal PricePerMonth { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Type = "Ноутбук";
        public int AmountMonth { get; set; }
    }
}
