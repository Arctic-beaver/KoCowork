using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Services
{
    public class CreateItemOrders
    {
        public void CreateOrdersForItem(ObservableCollection<IItemModel> ordersList, int orderId, int amountDays)
        {
            foreach (var item in ordersList)
            {
                switch (item)
                {
                    case LaptopModel laptop:
                        var laptopService = new LaptopService();
                        var laptopEntity = laptopService.ConvertModelToEntities(laptop);
                        var newLaptopOrder = new LaptopOrder{ Laptop = laptopEntity, OrderId = orderId, SubtotalPrice = laptopEntity.Price};
                        var addLaptopOrder = new LaptopOrderRepository();
                        addLaptopOrder.Add(newLaptopOrder);
                        break;
                    case MiniOfficeModel miniOffice:
                        var miniOfficeService = new MiniOfficeService();
                        var miniOfficeEntity = miniOfficeService.ConvertModelToEntities(miniOffice);
                        var newMiniOfficeOrder = new MiniOfficeOrder {MiniOffice = miniOfficeEntity, OrderId = orderId, SubtotalPrice = (miniOffice.PricePerDay * amountDays)};
                        var addMiniOfficeOrder = new MiniOfficeOrderRepository();
                        addMiniOfficeOrder.Add(newMiniOfficeOrder);
                        break;
                    case PlaceModel place:
                        var placeService = new PlaceService();
                        var placeEntity = placeService.
                        break;
                    case ProductModel product:
                        break;
                    case RoomModel room:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
