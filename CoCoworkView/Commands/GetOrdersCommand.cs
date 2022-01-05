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
        public GetOrdersCommand()
        {

        }

        public override void Execute(object viewModel)
        {
            OrderViewModel vm = (OrderViewModel)viewModel;

            vm.Orders.Clear();
           
            var orders = new List<OrderModel>();

            if (vm.ShowPaid) orders.AddRange(vm.Service.GetPaidOrders());
            if (vm.ShowUnpaid) orders.AddRange(vm.Service.GetUnpaidOrders());
            if (vm.ShowCanceled) orders.AddRange(vm.Service.GetCanceledOrders());
            if (vm.ShowActive) orders.AddRange(vm.Service.GetActiveOrders());

            orders.Distinct();

            foreach (OrderModel order in orders)
            {
                vm.Orders.Add(order);
            }
        }
    }
}
