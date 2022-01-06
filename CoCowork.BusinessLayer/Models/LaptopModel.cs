namespace CoCowork.BusinessLayer.Models
{
    public class LaptopModel : ItemModel
    {

        public int Number { get; set; }
        public decimal PricePerMonth { get; set; }
        public string TypeForDisplayInUI = "Ноутбук";
        public int AmountMonth { get; set; }

        public LaptopModel()
        {

        }


    }
}
