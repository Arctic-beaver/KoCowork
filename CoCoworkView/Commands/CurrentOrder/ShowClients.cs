using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoCowork.UI.Commands.CurrentOrder
{
    public class ShowClients:ICommand
    {
        public List<ClientModel> Clients
        { get;set;
        }

        public ShowClients()
        {
            var clientRepository = new ClientService();
            Clients = clientRepository.GetClients();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
