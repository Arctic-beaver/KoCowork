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
    public class GetClientsCommand : CommandBase
    {
        private readonly ClientViewModel _viewModel;
        private readonly ClientService _clientService;

        public GetClientsCommand(ClientViewModel viewModel, ClientService clientService)
        {
            _viewModel = viewModel;
            _clientService = clientService;
        }

        public override void Execute(object parameter)
        {
            //_viewModel.Clients = new ObservableCollection<ClientModel>(_clientService.GetClients());
            var clients = _clientService.GetClients();

            foreach (var item in clients)
            {
                _viewModel.Clients.Add(item);
            }
        }
    }
}
