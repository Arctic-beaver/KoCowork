namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : IItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type = "Продукты";
    }
}
