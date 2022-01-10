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
            TimeSpan startTime = new TimeSpan();
            TimeSpan endTime = new TimeSpan();
            bool result = CheckIfInputIsCorrect(startTime, endTime);

            if (result)
            {
                DateTime startDate = new DateTime();
                startDate = _addBookingItemVM.StartDatePicker;
                startTime = TimeSpan.Parse(_addBookingItemVM.StartTimePicker);

                DateTime endDate = new DateTime();
                endDate = _addBookingItemVM.EndDatePicker;
                endTime = TimeSpan.Parse(_addBookingItemVM.EndTimePicker);

                DateTime startOrderTimeAndDate = startDate.Add(startTime);
                DateTime endOrderTimeAndDate = endDate.Add(endTime);

                _bookingVM.BookingSelectedItem.StartDate = startOrderTimeAndDate;
                _bookingVM.BookingSelectedItem.EndDate = endOrderTimeAndDate;

                _bookingVM.BookingSelectedItem.CalculateSubtotalPrice(_bookingVM.BookingSelectedItem.Price);
                _vmCurrentOrder.CurrentOrder.Add(_bookingVM.BookingSelectedItem);

                _addBookingItemVM.GridVisibility = Visibility.Collapsed;
            }
        }

        private bool CheckIfInputIsCorrect(TimeSpan startTime, TimeSpan endTime)
        {
            if (_bookingVM.BookingSelectedItem is null)
            {
                MessageBox.Show("Выберите миниофис, компьютер, место или комнату для добавления в заказ",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!TimeSpan.TryParse(_addBookingItemVM.StartTimePicker, out _))
            {
                MessageBox.Show("Укажите правильное время начало брони", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (!TimeSpan.TryParse(_addBookingItemVM.EndTimePicker, out _))
            {
                MessageBox.Show("Укажите правильное время окончания брони", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}