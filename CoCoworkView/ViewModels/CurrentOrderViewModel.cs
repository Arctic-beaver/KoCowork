
using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands.CurrentOrder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class CurrentOrderViewModel : INotifyPropertyChanged
    {
        public CurrentOrderViewModel()
        {
            //Name = itemModel.Name;
            //GetObjectProperties(itemModel);

            //CurrentOrderList.Add(itemModel);


            AddOrder = new AddOrdersToDB(this);

            var clientService = new ClientService();
            var loadClients = clientService.GetClients();

            foreach (var item in loadClients)
            {
                Clients.Add(item);
            }
        }

        private ObservableCollection<IItemModel> _currentOrder;
        public ObservableCollection<IItemModel> CurrentOrder
        {
            get { return _currentOrder; }
            set
            {
                _currentOrder = value;
                OnPropertyChanged("CurrentOrder");
            }
        }

        private ObservableCollection<ClientModel> _clients;
        public ObservableCollection<ClientModel> Clients
        {
            get { return _clients; }
            set
            {
                _clients = value;
                OnPropertyChanged("Clients");
            }
        }

        private bool _isPaid;
        public bool IsPaid
        {
            get { return _isPaid; }
            set
            {
                _isPaid = value;
                OnPropertyChanged("IsPaid");
            }
        }
        private bool _isCancelled;
        public bool IsCancelled
        {
            get { return _isCancelled; }
            set
            {
                _isPaid = value;
                OnPropertyChanged("IsCancelled");
            }
        }

        private ClientModel _selectedClient;
        public ClientModel SelectedClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
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

        public int _totalPrice;
        public int TotalPrice
        {
            get { return _totalPrice; }
            set
            {
                _totalPrice = value;
                OnPropertyChanged("TotalPrice");
            }
        }

        public ICommand AddOrder
        {
            get;set;
        }

        public void GetObjectProperties(IItemModel itemModel)
        {
            switch (itemModel)
            {
                case LaptopModel laptop:
                    Type = laptop.Type;
                    Price = Convert.ToString(laptop.PricePerMonth);
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


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
