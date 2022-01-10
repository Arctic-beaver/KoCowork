using CoCowork.UI.Commands;
using System;
using System.Windows;

namespace CoCowork.UI.ViewModels
{
    internal class AddToCurrentOrders : CommandBase
    {
        private readonly CurrentOrderViewModel _vmCurrentOrder;
        private readonly AddBookingItemToCurrentOrderViewModel _addBookingItemVM;
        private readonly BookingViewModel _bookingVM;

        public AddToCurrentOrders(CurrentOrderViewModel vmCurrentOrder, BookingViewModel bookingVM, AddBookingItemToCurrentOrderViewModel addBookingItemVM)
        {
            _vmCurrentOrder = vmCurrentOrder;
            _addBookingItemVM = addBookingItemVM;
            _bookingVM = bookingVM;
        }

        public override void Execute(object parameter)
        {
            DateTime startDate = new DateTime();
            startDate = _addBookingItemVM.StartDatePicker;

            TimeSpan startTime = new TimeSpan();
            startTime = TimeSpan.Parse(_addBookingItemVM.StartTimePicker);

            DateTime startOrderTimeAndDate = startDate.Add(startTime);

            _bookingVM.BookingSelectedItem.StartDate = startOrderTimeAndDate;

            _bookingVM.BookingSelectedItem.CalculateSubtotalPrice(_bookingVM.BookingSelectedItem.Price);
            _vmCurrentOrder.CurrentOrder.Add(_bookingVM.BookingSelectedItem);

            _addBookingItemVM.GridVisibility = Visibility.Collapsed;
        }
    }
}