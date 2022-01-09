using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class ProductOrderRepository : BaseRepository, IProductOrderRepository
    {
        private const string _selectAllProcedure = "dbo.ProductOrder_SelectAll";
        private const string _selectByIdProcedure = "dbo.ProductOrder_SelectById";
        private const string _insertProcedure = "dbo.ProductOrder_Insert";
        private const string _updateProcedure = "dbo.ProductOrder_Update";
        private const string _deleteProcedure = "dbo.ProductOrder_Delete";

        public List<ProductOrder> GetAll()
        {
            using IDbConnection connection = ProvideConnection();
            return connection.Query<ProductOrder>(_selectAllProcedure).ToList();
        }

        public ProductOrder GetById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            return connection.
                Query<ProductOrder, Product, Order, ProductOrder>
                (_selectByIdProcedure,
                (productOrder, product, order) =>
                {
                    productOrder.Product = product;
                    productOrder.Order = order;
                    return productOrder;
                },
                new
                {
                    Id = id
                },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public int Add(ProductOrder productorder)
        {
            using IDbConnection connection = ProvideConnection();

            return connection.Execute(
                _insertProcedure,
                new
                {
                    ProductId = productorder.Product.Id,
                    OrderId = productorder.Order.Id,
                    Amount = productorder.Amount,
                    SubtotalPrice = productorder.SubtotalPrice

                },
                commandType: CommandType.StoredProcedure);
        }

        public void Update(ProductOrder productorder)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(
                _updateProcedure,
                new
                {
                    Id = productorder.Id,
                    ProductId = productorder.Product,
                    Order = productorder.Order,
                    Amount = productorder.Amount,
                    SubtotalPrice = productorder.SubtotalPrice

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
