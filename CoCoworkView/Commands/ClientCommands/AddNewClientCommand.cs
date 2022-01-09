using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Phone = _addClientVM.Phone,
                Email = _addClientVM.Email,
                BirthDate = _addClientVM.BirthDate,
                PaperAmount = _addClientVM.PaperAmount,
                PaperEndDate = _addClientVM.PaperEndDate

            };
            _clientService.AddClient(client);
            _clientVM.Clients.Add(client);
            _addClientVM.Phone = null;
            _addClientVM.Email = null;
            //_addClientVM.BirthDate = null;
            _addClientVM.PaperAmount = 0;
            //_addClientVM.PaperEndDate = null;
        }
    }
}
