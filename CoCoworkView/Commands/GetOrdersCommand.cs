using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.Commands
{
    public class GetOrdersCommand : CommandBase
    {
        public GetOrdersCommand(OrderViewModel vm, OrderService orderService)
        {
            var orders = orderService.GetAllOrders();

            foreach (var item in orders)
            {
                vm.Orders.Add(item);
            }
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
