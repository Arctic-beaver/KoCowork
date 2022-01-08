using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class ClientViewModel : TabViewModel
    {
        private ClientModel _selectedItem;

        private readonly ClientService _clientService;

        public ClientViewModel()
        {
            GridVisibility = Visibility.Hidden;

            _clientService = new ClientService();

            Clients = new ObservableCollection<ClientModel>();

            GetClientsCommand = new GetClientsCommand(this, _clientService);
        }

        public ObservableCollection<ClientModel> Clients { get; set; }
        

        public ClientModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (value != _selectedItem)
                {
                    _selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));

                }
            }
        }

        public ICommand GetClientsCommand { get; set; }




    }
}
