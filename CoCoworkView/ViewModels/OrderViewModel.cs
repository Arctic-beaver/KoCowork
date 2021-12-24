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
        private bool _isCancelButtonAvailable;

        private OrderModel _selectedItem;
        public OrderViewModel()
        {
            GridVisibility = Visibility.Hidden;
            ShowActiveAvailability = true;
            ShowCanceledAvailability = true;
            Service = new OrderService();
            Payment = new PaymentViewModel();

            GetOrdersCommand = new GetOrdersCommand();
            GetOrdersCommand.Execute(this);

            ChangePaymentVisibility = new VisibilityOfInnerGridCommand();
        }
        public PaymentViewModel Payment { get; set; }
        public ObservableCollection<OrderModel> Orders { get; set; }

        public bool ShowPaid
        {
            get => _showPaid;
            set
            {
                if (value != _showPaid)
                {
                    _showPaid = value;
                    OnPropertyChanged(nameof(ShowPaid));
                    GetOrdersCommand.Execute(this);
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
                    GetOrdersCommand.Execute(this);
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
                    GetOrdersCommand.Execute(this);
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
                    GetOrdersCommand.Execute(this);
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

        public bool IsCancelButtonAvailable
        {
            get => _isCancelButtonAvailable;
            set
            {
                if (value != _isCancelButtonAvailable)
                {
                    _isCancelButtonAvailable = value;
                    OnPropertyChanged(nameof(IsCancelButtonAvailable));
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
                    if (value != null) IsCancelButtonAvailable = true;
                }
            }
        }

        public ICommand GetOrdersCommand;

        public ICommand ChangePaymentVisibility;

        public OrderService Service;
    }
}
    

