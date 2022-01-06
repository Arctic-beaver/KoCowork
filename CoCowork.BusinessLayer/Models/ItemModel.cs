namespace CoCowork.BusinessLayer.Models
{
    public abstract class ItemModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public BookingChecker BookingChecker { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
