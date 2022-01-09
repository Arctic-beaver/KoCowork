using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        private const string _selectAllProc = "dbo.Client_SelectAll";
        private const string _selectByIdProc = "dbo.Client_SelectById";
        private const string _insertProc = "dbo.Client_Insert";
        private const string _updateProc = "dbo.Client_Update";
        private const string _deleteProc = "dbo.Client_Delete";

        public List<Client> GetAllClients()
        {
            using IDbConnection connection = ProvideConnection();
            return connection.Query<Client>(_selectAllProc).ToList();
        }

        public Client GetClientById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            return connection
                .QueryFirstOrDefault<Client>(
                    _selectByIdProc,
                    new { Id = id },
                    commandType: CommandType.StoredProcedure);
        }

        public void Add(Client client)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(_insertProc,
                new
                {
                    FirstName = client.FirstName,
                    LastName = client.LastName,
                    DateBirth = client.DateBirth,
                    Email = client.Email,
                    Phone = client.Phone,
                    PaperAmount = client.PaperAmount,
                    PaperEndDay = client.PaperEndDay
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdateClientById(Client client)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(_updateProc,
                new
                {
                    Id = client.Id,
                    FirstName = client.FirstName,
                    LastName = client.LastName,
                    DateBirth = client.DateBirth,
                    Phone = client.Phone,
                    PaperAmount = client.PaperAmount,
                    PaperEndDay = client.PaperEndDay
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeleteClientById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(_deleteProc,
                        new { Id = id },
                        commandType: CommandType.StoredProcedure);
        }
    }
}
