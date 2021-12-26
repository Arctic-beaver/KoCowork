namespace CoCowork.BusinessLayer.Models
{
    public class PlaceModel : IItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsFixed { get; set; }
        public int AmountDays { get; set; }
        public string Type = "Место";
    }
}
