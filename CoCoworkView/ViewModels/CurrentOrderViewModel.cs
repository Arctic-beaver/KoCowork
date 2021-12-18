
using CoCowork.BusinessLayer.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CoCowork.UI.ViewModels
{
    class CurrentOrderViewModel : INotifyPropertyChanged
    {
        public CurrentOrderViewModel(iItemModel itemModel)
        {
            Name = itemModel.Name;
            Type = GetType(itemModel);
            Price = GetPrice(itemModel);
            
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        private string _price;
        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }


        public string GetType(iItemModel itemModel)
        {
            string type = "";

            switch (itemModel)
            {
                case LaptopModel laptop:
                    return type = laptop.Type;
                case MiniOfficeModel miniOffice:
                    return type = miniOffice.Type;
                case PlaceModel place:
                    return type = place.Type;
                case ProductModel product:
                    return type = product.Type;
                case RoomModel room:
                    return type = room.Type;
                default:
                    return type;
            }
        }

        public string GetPrice(iItemModel iItemModel)
        {
            string price = "";
            switch (iItemModel)
            {
                case LaptopModel laptop:
                    return price = Convert.ToString(laptop.PricePerMonth) + " р. в месяц";
                case MiniOfficeModel miniOffice:
                    return price = Convert.ToString(miniOffice.PricePerDay) + " р. в день";
                case PlaceModel place:
                    return price = Convert.ToString(place.PricePerDay) + " р. в день";
                case ProductModel product:
                    return price = Convert.ToString(product.PriceForOne) + " р.";
                case RoomModel room:
                    return price = Convert.ToString(room.PricePerHour) + "р. в час";
                default:
                    return price;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
