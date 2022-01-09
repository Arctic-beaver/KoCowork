using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        private const string _selectAllProcedure = "dbo.Order_SelectAll";
        private const string _selectByIdProcedure = "dbo.Order_SelectById";
        private const string _insertProcedure = "dbo.Order_Insert";
        private const string _updateProcedure = "dbo.Order_Update";
        private const string _deleteProcedure = "dbo.Order_Delete";

        public List<Order> GetAll()
        {
            using IDbConnection connection = ProvideConnection();
            var result = connection.Query<Order>(_selectAllProcedure).ToList();
            return result;
        }

        public Order GetById(int id)
        {
            using IDbConnection connection = ProvideConnection();
            var OrderDictionary = new Dictionary<int, Order>();

            return connection
                .Query<Order, Payment, Order>(
                     _selectByIdProcedure,
                    (order, payment) =>
                    {
                        if (!OrderDictionary.TryGetValue(order.Id, out Order orderEntry))
                        {
                            orderEntry = order;
                            orderEntry.Payments = new List<Payment>();
                            OrderDictionary.Add(orderEntry.Id, orderEntry);
                        }
                        orderEntry.Payments.Add(payment);
                        return orderEntry;
                    },
                    new
                    {
                        Id = id
                    },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public int Add(Order order)
        {
            using IDbConnection connection = ProvideConnection();

            return connection.QueryFirstOrDefault<int>(
                _insertProcedure,
                new
                {
                    ClientId = order.ClientId,
                    TotalPrice = order.TotalPrice,
                    IsPaid = order.IsPaid,
                    IsCanceled = order.IsCanceled
                },
                commandType: CommandType.StoredProcedure);
        }

        public void Update(Order order)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(
                _updateProcedure,
                new
                {
                    Id = order.Id,
                    ClientId = order.ClientId,
                    TotalPrice = order.TotalPrice,
                    IsPaid = order.IsPaid,
                    IsCanceled = order.IsCanceled
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
