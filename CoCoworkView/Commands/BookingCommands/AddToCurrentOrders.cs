using CoCowork.UI.Commands;

namespace CoCowork.UI.ViewModels
{
    internal class AddToCurrentOrders : CommandBase
    {
        private readonly CurrentOrderViewModel _vmCurrentOrder;
        private readonly AddBookingItemToCurrentOrderViewModel _addBookingItemVM;
        private readonly BookingViewModel _vm;

        public AddToCurrentOrders(CurrentOrderViewModel vmCurrentOrder, BookingViewModel vm, AddBookingItemToCurrentOrderViewModel addBookingItemVM)
        {
            _vmCurrentOrder = vmCurrentOrder;
            _addBookingItemVM = addBookingItemVM;
            _vm = vm;
        }

        public override void Execute(object parameter)
        {
            //_vm.BookingSelectedItem.CalculateSubtotalPrice(_vm.BookingSelectedItem.Price);
            //_vmCurrentOrder.CurrentOrder.Add(_vm.BookingSelectedItem);

            //_vmCurrentOrder.RecalculateSum();
        }
    }
}