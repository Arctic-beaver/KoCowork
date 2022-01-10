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
            //Сначала проверим, надо ли добавлять оплату к данному заказу
            if (!CheckPayment())
            {
                //Создаём новую оплату.
                PaymentModel payment = new PaymentModel(_paymentViewModel.Amount, _paymentViewModel.PaymentDate, _paymentViewModel.OrderId);

                //Метод добавления оплаты сразу проверяет, покрыта ли итоговая стоимость после добавления.
                //Если да, отмечает заказ как оплаченный.
                _paymentViewModel.Service.Add(payment);
                MessageBox.Show("Оплата успешно добавлена!");
            }
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
