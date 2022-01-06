namespace CoCowork.BusinessLayer.Models
{
    abstract class BookingItemModel : ItemModel
    {
        public abstract decimal GetSubtotalPrice();

    }
}
