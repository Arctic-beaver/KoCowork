using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CoCowork.BusinessLayer.Models
{
    public class CurrentOrderModel
    {


        public CurrentOrderModel(IItemModel itemModel)
        {
            Name = itemModel.Name;
            GetObjectProperties(itemModel);
            CurrentOrderList.Add(itemModel);
            var laptops = new LaptopRepository();
            LaptopsList = laptops.GetAll();

        }

        public List<IItemModel> CurrentOrderList { get; set; }

        public List<Laptop> LaptopsList { get; set; }

        public ObservableCollection<ClientModel> Clients { get; set; }

        public ICommand GetClients { get; set; }


        public string Name
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }

        public string Price
        {
            get; set;
        }


        public void GetObjectProperties(IItemModel itemModel)
        {
            switch (itemModel)
            {
                case LaptopModel laptop:
                    Type = laptop.Type;
                    Price = Convert.ToString(laptop.Price);
                    break;
                case MiniOfficeModel miniOffice:
                    Type = miniOffice.Type;
                    Price = Convert.ToString(miniOffice.Price);
                    break;
                case PlaceModel place:
                    Type = place.Type;
                    Price = Convert.ToString(place.Price);
                    break;
                case ProductModel product:
                    Type = product.Type;
                    Price = Convert.ToString(product.Price);
                    break;
                case RoomModel room:
                    Type = room.Type;
                    Price = Convert.ToString(room.Price);
                    break;
                default:
                    break;
            }
        }


    }
}
