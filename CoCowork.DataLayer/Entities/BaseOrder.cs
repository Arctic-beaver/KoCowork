namespace CoCowork.DataLayer.Entities
{
    public abstract class BaseOrder
    {
        public int Id { get; }
        public decimal SubtotalPrice { get; set; }
        public Order Order { get; set; }
        //public abstract void CalculateSubtotalPrice(decimal price);


    }
}
