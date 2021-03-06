using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System.Collections.ObjectModel;

namespace CoCowork.BusinessLayer.Services
{
    public interface IItemOrdersService
    {
        void CreateOrdersForItem(ObservableCollection<ItemModel> ordersList, Order order);
    }
}