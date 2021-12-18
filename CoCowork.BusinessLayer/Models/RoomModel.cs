using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class RoomModel : iItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PricePerHour { get; set; }
        public string Type = "Комната";
    }
}
