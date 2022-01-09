using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Repositories;
using CoCowork.BusinessLayer.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoCowork.DataLayer.Entities;

namespace CoCowork.BusinessLayer.Services
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public List<ClientModel> GetClients()
        {
            var clients = _clientRepository.GetAllClients();
            return CustomMapper.GetInstance().Map<List<ClientModel>>(clients);
        }

        public void UpdateClient(ClientModel clientModel)
        {
            Client client = CustomMapper.GetInstance().Map<Client>(clientModel);
            _clientRepository.UpdateClientById(client);
        }

        public string AddClient (ClientModel clientModel)
        {
            Client client = CustomMapper.GetInstance().Map<Client>(clientModel);
            string result = string.Empty;
            try
            {
                _clientRepository.Add(client);
                result = "Успех";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;

        }
    }
}
