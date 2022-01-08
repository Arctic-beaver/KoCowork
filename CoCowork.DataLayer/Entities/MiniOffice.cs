using System.Collections.Generic;

namespace CoCowork.DataLayer.Entities
{
    public class MiniOffice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AmountOfPlaces { get; set; }
        public decimal PricePerDay { get; set; }
        public bool IsActive { get; set; }
        public List<Place> Places { get; set; }
    }
}
