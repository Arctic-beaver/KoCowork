using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands
{
    public class AddNewClientCommand : CommandBase
    {
        private readonly AddNewClientViewModel _addClientVM;
        private readonly ClientViewModel _clientVM;
        private readonly ClientService _clientService;

        public AddNewClientCommand(AddNewClientViewModel addClientViewModel, ClientViewModel clientViewModel, ClientService clientService)
        {
            _addClientVM = addClientViewModel;
            _clientVM = clientViewModel;
            _clientService = clientService;
        }
        public override void Execute(object parameter)
        {

            ClientModel client = new ClientModel
            {
                FirstName = _addClientVM.FirstName,
                LastName = _addClientVM.LastName,
                Phone = _addClientVM.Phone,
                Email = _addClientVM.Email,
                DateBirth = _addClientVM.DateBirth,
                PaperAmount = _addClientVM.PaperAmount,
                PaperEndDate = _addClientVM.PaperEndDate

            };
            _clientService.AddClient(client);
            _clientVM.Clients.Add(client);
            _addClientVM.LastName = null;
            _addClientVM.FirstName = null;
            _addClientVM.Phone = null;
            _addClientVM.Email = null;
            // _addClientVM.DateBirth = null;
            _addClientVM.PaperAmount = 0;
            //_addClientVM.PaperEndDate = null;
        }
    }
}
