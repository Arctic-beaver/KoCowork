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
    class CheckIfOrderIsPaidCommand : CommandBase
    {
        private readonly OrderViewModel _orderViewModel;
        public CheckIfOrderIsPaidCommand(OrderViewModel vm)
        {
            _orderViewModel = vm;
        }

        public override void Execute(object parameter)
        {
            if (_orderViewModel.Service.CheckPayment((int)_orderViewModel.Payment.OrderId))
            {
                _orderViewModel.Service.MarkAsPaid((int)_orderViewModel.Payment.OrderId);
                MessageBox.Show("Теперь заказ полностью оплачен!");
            }
        }
    }
}
