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
        private readonly PaymentViewModel _viewModel;
        public AddPaymentCommand(PaymentViewModel vm)
        {
            _viewModel = vm;
        }

        public override void Execute(object parameter)
        {
            PaymentModel payment = new PaymentModel(_viewModel.Amount, _viewModel.PaymentDate, _viewModel.OrderId);
            string message = _viewModel.Service.Add(payment);
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
