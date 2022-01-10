namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : ItemModel
    {
        public string TypeForDisplayInUI = "Продукты";

        public override void CalculateSubtotalPrice()
        {
            SubtotalPrice = Price;
        }
    }
}
