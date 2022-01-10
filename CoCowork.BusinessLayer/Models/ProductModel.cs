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
    }
}
