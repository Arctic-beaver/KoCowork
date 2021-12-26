﻿
using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands.CurrentOrder;
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

            _clientService = new ClientService();

            GetClients = new GetClientsCommand(this, _clientService);

            

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

        private ClientService _clientService;


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
                _isCancelled = false;
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


        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        _name = value;
        //        OnPropertyChanged("Name");
        //    }
        //}
        //private string _type;
        //public string Type
        //{
        //    get { return _type; }
        //    set
        //    {
        //        _type = value;
        //        OnPropertyChanged("Type");
        //    }
        //}



        //private string _price;
        //public string Price
        //{
        //    get { return _price; }
        //    set
        //    {
        //        _price = value;
        //        OnPropertyChanged("Price");
        //    }
        //}

        public void RecalculateSum()
        {
            foreach (var item in _currentOrder)
            {
                _totalPrice += GetItemModelSum(item);
            }
        }

        public decimal _totalPrice;
        public decimal TotalPrice
        {
            get { return _totalPrice; }
            set
            {
                _totalPrice = value;
                OnPropertyChanged("TotalPrice");
            }
        }

        public ICommand GetClients
        {
            get; set;
        }

        public ICommand AddOrder
        {
            get; set;
        }

        public decimal GetItemModelSum(IItemModel itemModel)
        {
            decimal sum = 0;

            switch (itemModel)
            {
                case LaptopModel laptop:
                    return sum = laptop.Price * laptop.AmountMonth;
                case MiniOfficeModel miniOffice:
                    return sum = miniOffice.Price * miniOffice.AmountDays;
                case PlaceModel place:
                    return sum = place.Price * place.AmountDays;
                case ProductModel product:
                    return sum = product.Price;
                case RoomModel room:
                    return sum = room.Price * room.AmountHours;
                default:
                    break;
            }
            return sum;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
