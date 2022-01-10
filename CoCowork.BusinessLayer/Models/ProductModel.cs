namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : ItemModel
    {
        public ProductModel()
        {
            TypeForDisplayInUI = "Продукты";
        }

        public override void CalculateSubtotalPrice(decimal price)
        {
            SubtotalPrice = price;
        }
        public int Amount { get; set; }

        public decimal PriceForOne { get; set; }

        
    }
}
