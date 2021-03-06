using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.CurrentOrder
{
    public class AddOrdersToDB : CommandBase
    {

        private readonly CurrentOrderViewModel _vm;

        private ClientService _clientService;
        private OrderService _orderService;
        private ItemOrdersService _createItemOrders;
        private OrderModel _orderModel;

        public AddOrdersToDB(CurrentOrderViewModel vm)
        {
            _vm = vm;
            _clientService = new ClientService();
            _orderService = new OrderService();
            _createItemOrders = new ItemOrdersService();


        }


        public override void Execute(object parameter)
        {
            if (_vm.SelectedClient == null)
            {
                MessageBox.Show("Сначала выберите клиента!");

            }
            else
            {
                _orderModel = new OrderModel { ClientId = _vm.SelectedClient.Id, IsCanceled = _vm.IsCancelled, IsPaid = _vm.IsPaid, TotalPrice = (decimal)_vm.TotalPrice };

                //var clientEntity = _clientService.FindClientInDB(_vm.SelectClient);
                var newOrder = _orderService.InsertOrder(_orderModel);

                _createItemOrders.CreateOrdersForItem(_vm.CurrentOrder, newOrder);
                MessageBox.Show("Заказ успешно сформирован!");
            }
        }
    }
}
