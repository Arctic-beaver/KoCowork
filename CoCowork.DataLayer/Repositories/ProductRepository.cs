using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        private const string _selectAllProcedure = "dbo.Product_SelectAll";
        private const string _selectByIdProcedure = "dbo.Product_SelectById";
        private const string _insertProcedure = "dbo.Product_Insert";
        private const string _updateProcedure = "dbo.Product_Update";
        private const string _deleteProcedure = "dbo.Product_Delete";

        public List<Product> GetAll()
        {
            using IDbConnection connection = ProvideConnection();
            return connection.Query<Product>(_selectAllProcedure).ToList();
        }

        public Product GetById(int id)
        {
            using IDbConnection connection = ProvideConnection();
            return connection.QueryFirstOrDefault<Product>(_selectByIdProcedure, new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public void Add(Product product)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(
                _insertProcedure,
                new
                {
                    Name = product.Name,
                    Amount = product.Amount,
                    PriceForOne = product.Price,
                    Description = product.Description
                },
                commandType: CommandType.StoredProcedure);
        }

        public void Update(Product product)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(
                _updateProcedure,
                new
                {
                    Id = product.Id,
                    Name = product.Name,
                    Amount = product.Amount,
                    PriceForOne = product.Price,
                    Description = product.Description
                },
                commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            using IDbConnection connection = ProvideConnection();

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
