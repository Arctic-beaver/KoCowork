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
    public class ProductRepository
    {
        private const string _connectionString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProcedure = "dbo.Product_SelectAll";
        private const string _selectByIdProcedure = "dbo.Product_SelectById";
        private const string _insertProcedure = "dbo.Product_Insert";
        private const string _updateProcedure = "dbo.Product_Update";
        private const string _deleteProcedure = "dbo.Product_Delete";

        public List<Product> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var result = connection.Query<Product>(_selectAllProcedure).ToList();

            return result;

        }

        public Product GetById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection.QueryFirstOrDefault<Product>(_selectByIdProcedure, new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public void Add(Product product)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.ExecuteScalar<Product>(
                _insertProcedure,
                new
                {
                    Id = product.Id,
                    Name = product.Name,
                    Amount = product.Amount,
                    PriceForOne = product.PriceForOne,
                    Description = product.Description

                },
                commandType: CommandType.StoredProcedure);
            ;
        }
        public void Update(Product product)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.ExecuteScalar<Product>(
                _updateProcedure,
                new
                {
                    Id = product.Id,
                    Name = product.Name,
                    Amount = product.Amount,
                    PriceForOne = product.PriceForOne,
                    Description = product.Description

                },
                commandType: CommandType.StoredProcedure);
            ;
        }
        public void Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.ExecuteScalar<Product>(
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
