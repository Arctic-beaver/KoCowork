using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System.Collections.ObjectModel;

namespace CoCowork.BusinessLayer.Services
{
    public class ItemOrdersService : IItemOrdersService
    {
        public ItemOrdersService()
        {

        }

        public void CreateOrdersForItem(ObservableCollection<ItemModel> ordersList, Order order)
        {

            foreach (var item in ordersList)
            {
                item.Order = order;
                item.ItemService.AddItemOrder(item);
            }
        }
    }
}
