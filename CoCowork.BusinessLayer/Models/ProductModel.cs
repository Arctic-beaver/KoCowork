namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : ItemModel
    {
        public ProductModel()
        {
            TypeForDisplayInUI = "Продукты";
        }

        public override void CalculateSubtotalPrice()
        {
            SubtotalPrice = Price;
        }
        public int Amount { get; set; }

        public decimal PriceForOne { get; set; }


    }
}
