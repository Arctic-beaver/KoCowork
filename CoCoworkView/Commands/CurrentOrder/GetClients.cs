using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using PseudoCalc.BusinessLayer.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoCowork.UI.Commands.CurrentOrder
{
    public class GetClients:CommandBase
    {
        private readonly CurrentOrderModel _vm;
        private readonly ClientService _clientService;

        public GetClients(CurrentOrderModel currentOrderModel, ClientService clientService)
        {
            _clientService = clientService;
            _vm = currentOrderModel;
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

      

        public override void Execute(object parameter)
        {
            _vm.Clients = _clientService.GetClients();
            
        }
    }
}
