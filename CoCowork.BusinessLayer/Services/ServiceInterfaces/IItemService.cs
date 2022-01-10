using CoCowork.BusinessLayer.Models;

namespace CoCowork.BusinessLayer.Services
{
    public interface IItemService
    {
        //void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price);
        //void AddItemOrder(ProductModel product);
        int AddItemOrder(ItemModel bookingItem);
        int AddItemOrder(BookingItemModel bookingItem);
    }
}
