using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Models
{
    public class MiniOfficeModel : ItemModel
    {
        public string Name { get; set; }
        public int AmountDays { get; set; }
        public string TypeForDisplayInUI = "Мини-офис";
        public int AmountOfPlaces { get; set; }
        public List<PlaceModel> Places { get; set; }
    }
}
