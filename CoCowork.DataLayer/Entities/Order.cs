namespace CoCowork.DataLayer.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsPaid { get; set; }
        public bool IsCancelled { get; set; }
    }
}
