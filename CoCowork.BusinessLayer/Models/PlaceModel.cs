

namespace CoCowork.BusinessLayer.Models
{
    public class PlaceModel : ItemModel
    {

        public bool IsFixed { get; set; }
        public int AmountDays { get; set; }
        public string TypeForDisplayInUI = "Место";
        public int Number { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PriceFixedPerDay { get; set; }

        public PlaceModel()
        {        }

    }
}