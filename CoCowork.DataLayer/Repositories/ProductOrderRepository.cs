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
    public class ProductOrderRepository
    {
        private const string _connectionString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProcedure = "dbo.ProductOrder_SelectAll";
        private const string _selectByIdProcedure = "dbo.ProductOrder_SelectById";
        private const string _insertProcedure = "dbo.ProductOrder_Insert";
        private const string _updateProcedure = "dbo.ProductOrder_Update";
        private const string _deleteProcedure = "dbo.ProductOrder_Delete";

        public List<ProductOrder> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var result = connection.Query<ProductOrder>(_selectAllProcedure).ToList();

            return result;

        }

        public ProductOrder GetById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection.QueryFirstOrDefault<ProductOrder>(_selectByIdProcedure, new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public void Add(ProductOrder productorder)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.ExecuteScalar<ProductOrder>(
                _insertProcedure,
                new
                {
                    Id = productorder.Id,
                    ProductId = productorder.ProductId,
                    OrderId = productorder.OrderId,
                    Amount = productorder.Amount,
                    SubtotalPrice = productorder.SubtotalPrice

                },
                commandType: CommandType.StoredProcedure);
            ;
        }
        public void Update(ProductOrder productorder)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.ExecuteScalar<ProductOrder>(
                _updateProcedure,
                new
                {
                    Id = productorder.Id,
                    ProductId = productorder.ProductId,
                    OrderId = productorder.OrderId,
                    Amount = productorder.Amount,
                    SubtotalPrice = productorder.SubtotalPrice

                },
                commandType: CommandType.StoredProcedure);
            ;
        }
        public void Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.ExecuteScalar<ProductOrder>(
                _deleteProcedure,
                new
                {
                    Id = id
                },
                commandType: CommandType.StoredProcedure);
            ;
        }
    }
}
