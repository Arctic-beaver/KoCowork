using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class OrderViewModel : TabViewModel
    {
        private bool _showPaid;
        private bool _showUnpaid;
        private bool _showCanceled;
        private bool _showActive;

        private bool _showCanceledAvailability;
        private bool _showActiveAvailability;
        private bool _cancelButtonAvailability;

        private OrderModel _selectedItem;
        public OrderViewModel()
        {
            GridVisibility = Visibility.Hidden;
            ShowActiveAvailability = true;
            ShowCanceledAvailability = true;
            CancelButtonAvailability = false;
            Service = new OrderService();
            GetOrdersCommand = new GetOrdersCommand(this, Service);
        }

        public ObservableCollection<OrderModel> Orders { get; set; }
        public ObservableCollection<OrderModel> PaidOrders { get; set; }
        public ObservableCollection<OrderModel> UnpaidOrders { get; set; }
        public ObservableCollection<OrderModel> CanceledOrders { get; set; }
        public ObservableCollection<OrderModel> ActiveOrders { get; set; }

        public bool ShowPaid
        {
            get => _showPaid;
            set
            {
                if (value != _showPaid)
                {
                    _showPaid = value;
                    OnPropertyChanged(nameof(ShowPaid));

                }
            }
        }

        public bool ShowUnpaid
        {
            get => _showUnpaid;
            set
            {
                if (value != _showUnpaid)
                {
                    _showUnpaid = value;
                    OnPropertyChanged(nameof(ShowUnpaid));
                }
            }
        }

        public bool ShowCanceled
        {
            get => _showCanceled;
            set
            {
                if (value != _showCanceled)
                {
                    _showCanceled = value;
                    if (value == true) ShowActiveAvailability = false;
                    else ShowActiveAvailability = true;
                    OnPropertyChanged(nameof(GridVisibility));
                }
            }
        }

        public bool ShowActive
        {
            get => _showActive;
            set
            {
                if (value != _showActive)
                {
                    _showActive = value;
                    if (value == true) ShowCanceledAvailability = false;
                    else ShowCanceledAvailability = true;
                    OnPropertyChanged(nameof(ShowActive));
                }
            }
        }

        public bool ShowCanceledAvailability
        {
            get => _showCanceledAvailability;
            set
            {
                if (value != _showCanceledAvailability)
                {
                    _showCanceledAvailability = value;
                    OnPropertyChanged(nameof(ShowCanceledAvailability));
                }
            }
        }

        public bool ShowActiveAvailability
        {
            get => _showActiveAvailability;
            set
            {
                if (value != _showActiveAvailability)
                {
                    _showActiveAvailability = value;
                    OnPropertyChanged(nameof(ShowActiveAvailability));
                }
            }
        }

        public bool CancelButtonAvailability
        {
            get => _cancelButtonAvailability;
            set
            {
                if (value != _cancelButtonAvailability)
                {
                    _cancelButtonAvailability = value;
                    OnPropertyChanged(nameof(_cancelButtonAvailability));
                }
            }
        }

        public OrderModel SelectedItem
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

        public ICommand GetOrdersCommand;

        public OrderService Service;

        //public bool IsButtonDeleteAvailable => 


    }
}
    

