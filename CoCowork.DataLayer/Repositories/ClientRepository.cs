using CoCowork.DataLayer.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Repositories
{
    class ClientRepository
    {
        private const string _connString = "Server=(local);Integrated Security=True;";

        //public List<Client> GetAllClients()
        //{
        //    using var connection = new SqlConnection(_connString);
        //    connection.Open();

            //var clientDictionary = new Dictionary<int, Client>();
            //var list = connection.Query<Client>(
            //    "dbo.Client_SelectAll",
            //    (client) =>
            //    {
            //        if (!clientDictionary.TryGetValue(client.Id, out var clientEntry))
            //        {

            //        }
            //    });
            

            


        //}
    }
}
