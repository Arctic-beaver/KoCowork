namespace CoCowork.BusinessLayer.Models
{
    public class RoomModel : ItemModel
    {

        public string Type { get; set; }
        public int AmountOfPeople { get; set; }
        public decimal PricePerHour { get; set; }
        public int AmountHours { get; set; }
        public string TypeForDisplayInUI = "Комната";

        public RoomModel()
        {
        }



    }
}