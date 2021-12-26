namespace CoCowork.DataLayer.Entities
{
    public interface IOrder
    {
        public int Id { get; }
        public decimal SubtotalPrice { get; set; }


    }
}
