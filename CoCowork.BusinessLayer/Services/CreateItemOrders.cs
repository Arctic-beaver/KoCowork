using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System.Collections.ObjectModel;

namespace CoCowork.BusinessLayer.Services
{
    public class CreateItemOrders
    {
        public void CreateOrdersForItem(ObservableCollection<IItemModel> ordersList, Order order, int amountDays, int bookingHour)
        {
            foreach (var item in ordersList)
            {
                switch (item)
                {
                    case LaptopModel laptop:
                        var laptopService = new LaptopService();
                        var laptopEntity = laptopService.ConvertModelToEntities(laptop);
                        var newLaptopOrder = new LaptopOrder { Laptop = laptopEntity, Order = order, SubtotalPrice = laptopEntity.Price };
                        var addLaptopOrder = new LaptopOrderRepository();
                        addLaptopOrder.Add(newLaptopOrder);
                        break;
                    case MiniOfficeModel miniOffice:
                        var miniOfficeService = new MiniOfficeService();
                        var miniOfficeEntity = miniOfficeService.ConvertModelToEntities(miniOffice);
                        var newMiniOfficeOrder = new MiniOfficeOrder { MiniOffice = miniOfficeEntity, Order = order, SubtotalPrice = (miniOffice.Price * amountDays) };
                        var addMiniOfficeOrder = new MiniOfficeOrderRepository();
                        addMiniOfficeOrder.Add(newMiniOfficeOrder);
                        break;
                    case PlaceModel place:
                        var placeService = new PlaceService();
                        var placeEntity = placeService.ConvertModelToEntities(place);
                        var newPlaceOrder = new PlaceOrder { Place = placeEntity, Order = order, SubtotalPrice = placeEntity.PriceFixedPerDay };
                        var addPlaceOrder = new PlaceOrderRepository();
                        addPlaceOrder.Add(newPlaceOrder);
                        break;
                    case ProductModel product:
                        var productService = new ProductService();
                        var productEntity = productService.ConvertModelToEntities(product);
                        var newProductOrder = new ProductOrder { Product = productEntity, Order = order, SubtotalPrice = productEntity.PriceForOne };
                        var addProductOrder = new ProductOrderRepository();
                        addProductOrder.Add(newProductOrder);
                        break;
                    case RoomModel room:
                        var roomService = new RoomService();
                        var roomEntity = roomService.ConvertModelToEntities(room);
                        var newRoomOrder = new RoomOrder { Room = roomEntity, Order = order, SubtotalPrice = (roomEntity.PricePerHour * bookingHour) };
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
