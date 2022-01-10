using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CoCowork.UI.Commands
{
    public class GetOrdersCommand : CommandBase
    {
        private readonly OrderViewModel _orderViewModel;
        public GetOrdersCommand(OrderViewModel ovm)
        {
            _orderViewModel = ovm;
        }

        public override void Execute(object viewModel)
        {
            _orderViewModel.Orders.Clear();

            var orders = new List<OrderModel>();

            orders.AddRange(_orderViewModel.Service.GetSpecialOrders(_orderViewModel.ShowPaid, _orderViewModel.ShowUnpaid, _orderViewModel.ShowCanceled));

            foreach (OrderModel order in orders)
            {
                _orderViewModel.Orders.Add(order);
            }
        }
    }
}
