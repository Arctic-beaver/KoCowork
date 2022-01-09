﻿
using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands.CurrentOrder;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class CurrentOrderViewModel : TabViewModel
    {

        private ObservableCollection<ItemModel> _currentOrder;
        public ObservableCollection<ItemModel> CurrentOrder
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
        public ClientModel SelectClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;

                OnPropertyChanged("SelectedClient");
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
        public CurrentOrderViewModel()
        {
            Clients = new ObservableCollection<ClientModel>();
            CurrentOrder = new ObservableCollection<ItemModel>();

            _clientService = new ClientService();
            GetClients = new GetClientsCommand(this, _clientService);

            GridVisibility = Visibility.Hidden;
            AddOrder = new AddOrdersToDB(this);
        }

        public ICommand GetClients { get; set; }

        public ICommand AddOrder { get; set; }

       


    }
}
