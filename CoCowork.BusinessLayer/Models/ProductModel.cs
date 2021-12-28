namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : ItemModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type = "Продукты";
    }
}
