using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class ComputerModel : ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public BookingChecker BookingChecker { get; set; }
        public decimal PricePerMonth { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
