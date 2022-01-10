using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.OrderHistoryCommands
{
    public class CheckIfShouldOpenAddingPaymentGrid : CommandBase
    {
        private readonly PaymentViewModel _paymentViewModel;
        private readonly OrderViewModel _orderViewModel;

        public CheckIfShouldOpenAddingPaymentGrid(PaymentViewModel vm, OrderViewModel ovm)
        {
            _paymentViewModel = vm;
            _orderViewModel = ovm;
        }

        public override void Execute(object parameter)
        {
            if (_paymentViewModel.GridVisibility != Visibility.Visible && !CheckPayment() ||
                _paymentViewModel.GridVisibility == Visibility.Visible)

                _paymentViewModel.ChangePaymentVisibility.Execute(null);
        }

        private bool CheckPayment()
        {
            if (_orderViewModel.Service.CheckPayment((int)_paymentViewModel.OrderId))
            {
                MessageBox.Show("Этот заказ полностью оплачен.");
                return true;
            }
            return false;
        }
    }
}
