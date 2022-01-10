using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;
using System.Collections.Generic;

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

            orders.AddRange(vm.Service.GetSpecialOrders(vm.ShowPaid, vm.ShowUnpaid, vm.ShowCanceled));

            foreach (OrderModel order in orders)
            {
                vm.Orders.Add(order);
            }
        }
    }
}
