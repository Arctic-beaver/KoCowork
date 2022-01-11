using CoCowork.UI.Commands;
using System;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class AddBookingItemToCurrentOrderViewModel : InnerGridViewModel
    {
        private bool _isAddButtonAvailable;
        private DateTime _startDatePicker;
        private DateTime _endDatePicker;
        private string _startTimePicker;
        private string _endTimePicker;

        public bool IsAddButtonAvailable
        {
            get => _isAddButtonAvailable;
            set
            {
                if (value != _isAddButtonAvailable)
                {
                    _isAddButtonAvailable = value;
                    OnPropertyChanged(nameof(IsAddButtonAvailable));
                    IsAddButtonAvailable = StartTimePicker != null && EndTimePicker != null;
                }
            }
        }

        public DateTime StartDatePicker
        {
            get => _startDatePicker;
            set
            {
                if (value != _startDatePicker)
                {
                    _startDatePicker = value;
                    OnPropertyChanged(nameof(StartDatePicker));
                    //IsAddButtonAvailable = 
                }
            }
        }

        public DateTime EndDatePicker
        {
            get => _endDatePicker;
            set
            {
                if (value != _endDatePicker)
                {
                    _endDatePicker = value;
                    OnPropertyChanged(nameof(EndDatePicker));
                    //IsAddButtonAvailable = 
                }
            }
        }

        public string StartTimePicker
        {
            get => _startTimePicker;
            set
            {
                if (value != _startTimePicker)
                {
                    _startTimePicker = value;
                    OnPropertyChanged(nameof(StartTimePicker));
                    //IsAddButtonAvailable = 
                }
            }
        }

        public string EndTimePicker
        {
            get => _endTimePicker;
            set
            {
                if (value != _endTimePicker)
                {
                    _endTimePicker = value;
                    OnPropertyChanged(nameof(EndTimePicker));
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
            StartDatePicker = DateTime.Now;
            EndDatePicker = DateTime.Now;
        }
    }
}
