using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class ClientRepository
    {
        private const string _connString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProc = "dbo.Client_SelectAll";
        private const string _selectByIdProc = "dbo.Client_SelectById";
        private const string _insertProc = "dbo.Client_Insert";
        private const string _updateProc = "dbo.Client_Update";
        private const string _deleteProc = "dbo.Client_Delete";

        public List<Client> GetAllClients()
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            var result = connection
                .Query<Client>
                (_selectAllProc)
                .ToList();

            return result;
        }

        public Client GetClientById(int id)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            return connection
                .QueryFirstOrDefault<Client>(
                _selectByIdProc,
                new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public void Add(Client client)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.ExecuteScalar<Client>(
                _insertProc,
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

        public void UpdateClientById(int id, Client client)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            var affectedRows = connection.ExecuteScalar<Client>(
                _updateProc,
                new
                {
                    Id = id,
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
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.ExecuteScalar<Client>(
                _deleteProc,
                new
                {
                    Id = id
                },
                commandType: CommandType.StoredProcedure);
        }
    }
}
