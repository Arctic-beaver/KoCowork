using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IClientRepository
    {
        void Add(Client client);
        void DeleteClientById(int id);
        List<Client> GetAllClients();
        Client GetClientById(int id);
        void UpdateClientById(Client client);
    }
}