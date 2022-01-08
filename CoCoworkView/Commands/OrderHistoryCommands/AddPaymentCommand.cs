using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CoCowork.UI.Commands.OrderHistoryCommands
{
    class AddPaymentCommand : CommandBase
    {
        private readonly PaymentViewModel _paymentViewModel;
        public AddPaymentCommand(PaymentViewModel vm)
        {
            _paymentViewModel = vm;
        }

        public override void Execute(object parameter)
        {
            PaymentModel payment = new PaymentModel(_paymentViewModel.Amount, _paymentViewModel.PaymentDate, _paymentViewModel.OrderId);
            string message = _paymentViewModel.Service.Add(payment);
            if (message.Equals("Success"))
            {
                MessageBox.Show("Оплата успешно добавлена!");
            }
            else
            {
                MessageBox.Show($"Возникла ошибка: {message}");
            }
        }
    }
}
