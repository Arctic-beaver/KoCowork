using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Entities;

namespace CoCowork.BusinessLayer.Models
{
    public abstract class ItemModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string TypeForDisplayInUI { get; set; }
        public BookingChecker BookingChecker { get; set; }
        public IItemService ItemService { get; set; }
        public Order Order { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SubtotalPrice { get; set; }

        public abstract void CalculateSubtotalPrice(decimal price);
    }
}
