using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Collections.ObjectModel;

namespace CoCowork.UI.Commands.CurrentOrder
{
    public class GetClientsCommand : CommandBase
    {
        private readonly CurrentOrderViewModel _vm;
        private readonly ClientService _clientService;

        public GetClientsCommand(CurrentOrderViewModel currentOrderModel, ClientService clientService)
        {
            _clientService = clientService;
            _vm = currentOrderModel;
        }



        public override void Execute(object parameter)
        {
            _vm.Clients = new ObservableCollection<ClientModel>(_clientService.GetClients());
        }
    }
}
