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
    class CancelOrderCommand : CommandBase
    {
        OrderViewModel _orderViewModel;
        public CancelOrderCommand(OrderViewModel orderViewModel)
        {
            _orderViewModel = orderViewModel;
        }

        public override void Execute(object viewModel)
        {
            OrderModel orderModel = _orderViewModel.Orders.FirstOrDefault(x => x.Id == _orderViewModel.SelectedItem.Id);

            orderModel.IsCanceled = true;
            _orderViewModel.Service.UpdateOrder(orderModel);

            MessageBox.Show("Заказ отменён.");

            _orderViewModel.GetOrdersCommand.Execute(_orderViewModel);
        }
    }
}
