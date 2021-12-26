namespace CoCowork.BusinessLayer.Models
{
    public class RoomModel : IItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AmountHours { get; set; }
        public string Type = "Комната";
    }
}
