using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IClientRepository
    {
        int Add(Client client);
        void DeleteClientById(int id);
        List<Client> GetAll();
        Client GetClientById(int id);
        void UpdateClientById(Client client);
    }
}