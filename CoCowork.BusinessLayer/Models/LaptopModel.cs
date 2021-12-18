using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class LaptopModel : iItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerMonth { get; set; }
        public string Type = "Ноутбук";
    }
}
