using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.Commands
{
    public class GetOrdersCommand : CommandBase
    {        
        public GetOrdersCommand(OrderViewModel vm, OrderService orderService)
        {
            vm.Orders?.Clear();
            var orders = new List<OrderModel>();

            if (vm.ShowPaid) orders.AddRange(orderService.GetPaidOrders());
            if (vm.ShowUnpaid) orders.AddRange(orderService.GetUnpaidOrders());
            if (vm.ShowCanceled) orders.AddRange(orderService.GetCanceledOrders());
            if (vm.ShowActive) orders.AddRange(orderService.GetActiveOrders());

            orders.Distinct();

            vm.Orders = new ObservableCollection<OrderModel>(orders);
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
