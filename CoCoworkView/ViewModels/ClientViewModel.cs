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

        private string _phone;
        private string _email;
        private DateTime _birthDate;
        private int _paperAmount;
        private DateTime _paperEndDate;
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
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        public int PaperAmount
        {
            get => _paperAmount;
            set
            {
                _paperAmount = value;
                OnPropertyChanged(nameof(PaperAmount));
            }
        }

        public DateTime PaperEndDate
        {
            get => _paperEndDate;
            set
            {
                _paperEndDate = value;
                OnPropertyChanged(nameof(PaperAmount));
            }
        }

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
