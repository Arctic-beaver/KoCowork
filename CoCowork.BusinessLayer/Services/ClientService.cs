using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using PseudoCalc.BusinessLayer.Configuration;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public List<ClientShortModel> GetClientsWithoutSensitiveData()
        {
            var players = _clientRepository.GetAllClients();
            return CustomMapper.GetInstance().Map<List<ClientShortModel>>(players);
        }

        public List<ClientModel> GetClients()
        {
            var players = _clientRepository.GetAllClients();
            return CustomMapper.GetInstance().Map<List<ClientModel>>(players);
        }

        public Client ConvertClientModelToEntities(ClientModel clientModel)
        {
            return CustomMapper.GetInstance().Map<Client>(clientModel);
        }
    }
}
