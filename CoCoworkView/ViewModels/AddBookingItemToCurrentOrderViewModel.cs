using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class AddBookingItemToCurrentOrderViewModel : InnerGridViewModel
    {
        private bool _isAddButtonAvailable;

        public bool IsAddButtonAvailable
        {
            get => _isAddButtonAvailable;
            set
            {
                if (value != _isAddButtonAvailable)
                {
                    _isAddButtonAvailable = value;
                    OnPropertyChanged(nameof(IsAddButtonAvailable));
                    //IsAddButtonAvailable = 
                }
            }
        }

        public ICommand AddToCurrentOrders { get; set; }
        public ICommand ChangeInnerGridVisibility { get; set; }
        public AddBookingItemToCurrentOrderViewModel(BookingViewModel bookingVM, CurrentOrderViewModel currentOrderVM)
        {
            GridVisibility = Visibility.Collapsed;

            AddToCurrentOrders = new AddToCurrentOrders(currentOrderVM, bookingVM, this);
            ChangeInnerGridVisibility = new VisibilityOfInnerGridCommand(this);
        }
    }
}
