using CoCowork.DataLayer.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Repositories
{
    public class OrderRepository
    {
        private const string _connectionString = "Server=80.78.240.16;User ID=student;Password=qwe!23;Database=CoCowork.DB";
        private const string _selectAllProcedure = "dbo.Order_SelectAll";
        private const string _selectByIdProcedure = "dbo.Order_SelectById";
        private const string _insertProcedure = "dbo.Order_Insert";
        private const string _updateProcedure = "dbo.Order_Update";
        private const string _deleteProcedure = "dbo.Order_Delete";

        public List<Order> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var result = connection.Query<Order>(_selectAllProcedure).ToList();

            return result;

        }

        public Order GetById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection.QueryFirstOrDefault(_selectByIdProcedure,new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public void Add (Order order)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.Execute(
                _insertProcedure,
                new
                {
                    ClientId = order.Client,
                    TotalPrice = order.TotalPrice,
                    IsPaid = order.IsPaid,
                    IsCancelled = order.IsCancelled

                },
                commandType: CommandType.StoredProcedure);
        } 

        public void Update (Order order)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.Execute(
                _updateProcedure,
                new
                {
                    Id = order.Id,
                    ClientId = order.Client,
                    TotalPrice = order.TotalPrice,
                    IsPaid = order.IsPaid,
                    IsCancelled = order.IsCancelled

                },
                commandType: CommandType.StoredProcedure);
        }
        public void Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.Execute(
                _deleteProcedure,
                new
                {
                    Id = id
                },
                commandType: CommandType.StoredProcedure);
        }

    }
}
