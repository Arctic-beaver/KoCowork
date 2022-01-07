using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System;
using System.Collections.ObjectModel;

namespace CoCowork.BusinessLayer.Services
{
    public class CreateItemOrders : ICreateItemOrders
    {
        public void CreateOrdersForItem(ObservableCollection<ItemModel> ordersList, Order order)
        {

            foreach (var item in ordersList)
            {
                item.ItemService.AddItemOrder(item.Id, order, DateTime.Now, DateTime.Now, item.SubtotalPrice);
            }
        }
    }
}
