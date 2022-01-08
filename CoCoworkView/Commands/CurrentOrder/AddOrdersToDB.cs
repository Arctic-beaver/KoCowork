using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.CurrentOrder
{
    public class AddOrdersToDB : CommandBase
    {

        private CurrentOrderViewModel _vm;

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
            if (_vm.SelectClient == null)
            {
                MessageBox.Show("Сначала выберите клиента!");

            }
            else
            {
                _orderModel = new OrderModel { Client = _vm.SelectClient, IsCancelled = _vm.IsCancelled, IsPaid = _vm.IsPaid, TotalPrice = _vm.TotalPrice };

                //var clientEntity = _clientService.FindClientInDB(_vm.SelectClient);
                var newOrder = _orderService.InsertOrder(_orderModel);

                _createItemOrders.CreateOrdersForItem(_vm.CurrentOrder, newOrder);
                MessageBox.Show("Заказ успешно сформирован!");
            }



        }
    }
}
