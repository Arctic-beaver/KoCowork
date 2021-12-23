using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;
using Dapper;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using PseudoCalc.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Services;

namespace CoCowork.UI.Commands.CurrentOrder
{
    public class AddOrdersToBD : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public List<IItemModel> ListOrders {get; set; }

        public bool IsPaid { get; set; }
        public decimal Price { get; set; }
        public AddOrdersToBD(CurrentOrderViewModel vm)
        {
            var newOrder = new Order();
        }



        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {


            var newOrder = new OrderService();
            int orderId = OrderService.CreateNewOrder(client,);

            int idOrder = createNewOrder.Add(newOrder);

            foreach (var item in ListOrders)
            {
                switch (item)
                {
                    case LaptopModel laptop:
                        var laptopEntities = new Lap
                        var newLaptopOrder = new LaptopOrder { Laptop = laptop, };
                        var addLaptopOrder = new LaptopOrderRepository();
                        addLaptopOrder.Add(newLaptopOrder);
                        break;
                    case MiniOfficeModel miniOffice:
                        Type = miniOffice.Type;
                        Price = Convert.ToString(miniOffice.PricePerDay);
                        break;
                    case PlaceModel place:
                        Type = place.Type;
                        Price = Convert.ToString(place.PricePerDay);
                        break;
                    case ProductModel product:
                        Type = product.Type;
                        Price = Convert.ToString(product.PriceForOne);
                        break;
                    case RoomModel room:
                        Type = room.Type;
                        Price = Convert.ToString(room.PricePerHour);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
