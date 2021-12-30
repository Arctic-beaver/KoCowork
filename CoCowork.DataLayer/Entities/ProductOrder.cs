namespace CoCowork.DataLayer.Entities
{
    public class ProductOrder : BaseOrder
    {
        public Product Product { get; set; }
        public Order Order { get; set; }
        public int Amount { get; set; } 
    }
}
