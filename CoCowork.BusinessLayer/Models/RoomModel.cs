using CoCowork.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
namespace CoCowork.BusinessLayer.Models
    public class RoomModel : ItemModel
        public string Type { get; set; }
        public int AmountOfPeople { get; set; }
        public decimal PricePerHour { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int AmountHours { get; set; }
        public string Type = "Комната";
    }
}