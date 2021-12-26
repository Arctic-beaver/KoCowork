using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class PlaceModel : ItemModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public BookingChecker BookingChecker { get; set; }
        public int Number { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PriceFixedPerDay { get; set; }
        public string Description { get; set; }
    }
}