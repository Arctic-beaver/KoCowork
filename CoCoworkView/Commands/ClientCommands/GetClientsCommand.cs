using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

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
            var clients = _clientService.GetAll();

            foreach (var item in clients)
            {
                _viewModel.Clients.Add(item);
            }
        }
    }
}
