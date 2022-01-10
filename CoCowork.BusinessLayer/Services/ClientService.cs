using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
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
            var clients = _clientRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<ClientModel>>(clients);
        }

        public Client FindClientInDB(ClientModel clientModel)
        {
            var client = _clientRepository.GetClientById(clientModel.Id);
            return client;
        }

        public void UpdateClient(ClientModel clientModel)
        {
            Client client = CustomMapper.GetInstance().Map<Client>(clientModel);
            _clientRepository.UpdateClientById(client);
        }

        public string AddClient (ClientModel clientModel) //Change!!!!!
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
