using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class ProductRepository
    {
        private const string _connectionString = "Server=80.78.240.16;User ID=student;Password=qwe!23;Database=CoCowork.DB";
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
            connection.Execute(
                _insertProcedure,
                new
                {
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
            connection.Execute(
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

            connection.Execute(
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
