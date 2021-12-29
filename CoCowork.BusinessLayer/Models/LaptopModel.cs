namespace CoCowork.BusinessLayer.Models
{
    public class LaptopModel : ItemModel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal PricePerMonth { get; set; }
        public string Description { get; set; }
        public string TypeForDisplayInUI = "Ноутбук";
        public int AmountMonth { get; set; }
    }
}
