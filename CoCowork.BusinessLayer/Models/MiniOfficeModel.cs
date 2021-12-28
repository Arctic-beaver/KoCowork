namespace CoCowork.BusinessLayer.Models
{
    public class MiniOfficeModel : IItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AmountDays { get; set; }
        public string Type = "Мини-офис";
        public int AmountOfPlaces { get; set; }
        public List<PlaceModel> Places { get; set; }
    }
}
