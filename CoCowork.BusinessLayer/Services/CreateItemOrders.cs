using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System.Collections.ObjectModel;

namespace CoCowork.BusinessLayer.Services
{
    public class CreateItemOrders
    {
        public void CreateOrdersForItem(ObservableCollection<IItemModel> ordersList, Order order)
        {
            foreach (var item in ordersList)
            {
                switch (item)
                {
                    case LaptopModel laptop:
                        var laptopService = new LaptopRepository();
                        Laptop laptopEntity = laptopService.GetAll().Find(x => x.Id == laptop.Id);
                        var newLaptopOrder = new LaptopOrder { Laptop = laptopEntity, Order = order, SubtotalPrice = laptopEntity.Price, StartDate = System.DateTime.Now, EndDate = System.DateTime.Now };
                        var addLaptopOrder = new LaptopOrderRepository();
                        addLaptopOrder.Add(newLaptopOrder);
                        break;
                    case MiniOfficeModel miniOffice:
                        var miniOfficeService = new MiniOfficeRepository();
                        MiniOffice miniOfficeEntity = miniOfficeService.GetAll().Find(x => x.Id.Equals(miniOffice.Id));
                        var newMiniOfficeOrder = new MiniOfficeOrder { MiniOffice = miniOfficeEntity, Order = order, SubtotalPrice = miniOffice.Price, StartDate = System.DateTime.Now, EndDate = System.DateTime.Now};
                        var addMiniOfficeOrder = new MiniOfficeOrderRepository();
                        addMiniOfficeOrder.Add(newMiniOfficeOrder);
                        break;
                    case PlaceModel place:
                        var placeService = new PlaceRepository();
                        Place placeEntity = placeService.GetAll().Find(x => x.Id.Equals(place.Id));
                        var newPlaceOrder = new PlaceOrder { Place = placeEntity, Order = order, SubtotalPrice = placeEntity.PricePerDay, StartDate = System.DateTime.Now, EndDate = System.DateTime.Now };
                        var addPlaceOrder = new PlaceOrderRepository();
                        addPlaceOrder.Add(newPlaceOrder);
                        break;
                    case ProductModel product:
                        var productService = new ProductRepository();
                        Product productEntity = productService.GetAll().Find(x => x.Id.Equals(product.Id)); 
                        var newProductOrder = new ProductOrder { Product = productEntity, Order = order, SubtotalPrice = productEntity.Price};
                        var addProductOrder = new ProductOrderRepository();
                        addProductOrder.Add(newProductOrder);
                        break;
                    case RoomModel room:
                        var roomService = new RoomRepository();
                        Room roomEntity = roomService.GetAll().Find(x => x.Id.Equals(room.Id));
                        var newRoomOrder = new RoomOrder { Room = roomEntity, Order = order, SubtotalPrice = (roomEntity.Price), StartDate = System.DateTime.Now, EndDate = System.DateTime.Now };
                        var addRoomOrder = new RoomOrderRepository();
                        addRoomOrder.Add(newRoomOrder);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
