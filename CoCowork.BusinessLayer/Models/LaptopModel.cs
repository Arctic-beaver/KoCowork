namespace CoCowork.BusinessLayer.Models
{
    public class LaptopModel : IItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type = "Ноутбук";
        public int AmountMonth { get; set; }
    }
}
