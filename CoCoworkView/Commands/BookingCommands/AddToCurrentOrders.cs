using CoCowork.BusinessLayer.Models;
using CoCowork.UI.Commands;
using System.Collections.ObjectModel;

namespace CoCowork.UI.ViewModels
{
    internal class AddToCurrentOrders : CommandBase
    {

        private CurrentOrderViewModel _vmCurrentOrder;
        private BookingViewModel _vm;

        public AddToCurrentOrders(CurrentOrderViewModel vmCurrentOrder, BookingViewModel vm)
        {
            _vmCurrentOrder = vmCurrentOrder;
            _vm = vm;
        }

        public override void Execute(object parameter)
        {
            _vm.BookingSelectedItem.CalculateSubtotalPrice(_vm.BookingSelectedItem.Price);
            _vmCurrentOrder.CurrentOrder.Add(_vm.BookingSelectedItem);
            
            _vmCurrentOrder.RecalculateSum();
        }
    }
}