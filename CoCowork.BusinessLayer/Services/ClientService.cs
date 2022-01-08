using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public List<ClientModel> GetAll()
        {
            var players = _clientRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<ClientModel>>(players);
        }

        public Client FindClientInDB(ClientModel clientModel)
        {
            var client = _clientRepository.GetClientById(clientModel.Id);
            return client;
        }
    }
}
