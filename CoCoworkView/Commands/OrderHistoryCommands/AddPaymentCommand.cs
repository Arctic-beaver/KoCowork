using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.OrderHistoryCommands
{
    class AddPaymentCommand : CommandBase
    {
        private readonly PaymentViewModel _paymentViewModel;
        private readonly OrderViewModel _orderViewModel;

        public AddPaymentCommand(PaymentViewModel vm, OrderViewModel ovm)
        {
            _paymentViewModel = vm;
            _orderViewModel = ovm;
        }

        public override void Execute(object parameter)
        {
            if (_orderViewModel.Service.CheckPayment((int)_paymentViewModel.OrderId))
            {
                MessageBox.Show("Этот заказ полностью оплачен.");
                //return;
            }

            PaymentModel payment = new PaymentModel(_paymentViewModel.Amount, _paymentViewModel.PaymentDate, _paymentViewModel.OrderId);
            string message = _paymentViewModel.Service.Add(payment);
            if (message.Equals("Success"))
            {
                MessageBox.Show("Оплата успешно добавлена!");
                _orderViewModel.CheckIfOrderIsPaidCommand.Execute(null);
            }
            else
            {
                MessageBox.Show($"Возникла ошибка: {message}");
            }

            _paymentViewModel.ChangePaymentVisibility.Execute(null);
        }
    }
}
