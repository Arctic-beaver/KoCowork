using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CoCowork.BusinessLayer.Models
{
    public class MiniOfficeModel : ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public BookingChecker BookingChecker { get; set; }
        public int AmountOfPlaces { get; set; }
        public decimal PricePerDay { get; set; }
        public List<PlaceModel> Places { get; set; }
    }
}
