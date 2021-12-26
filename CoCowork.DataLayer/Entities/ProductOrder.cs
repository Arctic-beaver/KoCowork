namespace CoCowork.DataLayer.Entities
{
    public class ProductOrder : IOrder
    {
        public int Id { get; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public int Amount { get; set; }
        public decimal SubtotalPrice { get; set; }
    }
}
