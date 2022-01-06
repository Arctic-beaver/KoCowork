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
        private CreateItemOrders _createItemOrders;

        public AddOrdersToDB(CurrentOrderViewModel vm)
        {
            _vm = vm;
            _clientService = new ClientService();
            _orderService = new OrderService();
            _createItemOrders = new CreateItemOrders();


        }


        public override void Execute(object parameter)
        {
            if (_vm.SelectedClient == null)
            {
                MessageBox.Show("Сначала выберите клиента!");

            }
            else
            {
                var clientEntity = _clientService.FindClientInDB(_vm.SelectedClient);
                var newOrder = _orderService.GenerateNewOrder(clientEntity, _vm.IsCancelled, _vm.IsPaid, _vm.TotalPrice);

                _createItemOrders.CreateOrdersForItem(_vm.CurrentOrder, newOrder);
                MessageBox.Show("Заказ успешно сформирован!");
            }



        }
    }
}
