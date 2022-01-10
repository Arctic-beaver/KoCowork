using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public interface IClientService
    {
        Client FindClientInDB(ClientModel clientModel);
        List<ClientModel> GetAll();
        void UpdateClient(ClientModel clientModel);
        string AddClient(ClientModel clientModel);


    }
}