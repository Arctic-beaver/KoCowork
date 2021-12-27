using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class MiniOfficeOrderRepository : BaseRepository, IMiniOfficeOrderRepository
    {
        private const string _selectAllProcedure = "dbo.MiniOfficeOrder_SelectAll";
        private const string _selectByIdProcedure = "dbo.MiniOfficeOrder_SelectById";
        private const string _insertProcedure = "dbo.MiniOfficeOrder_Insert";
        private const string _updateProcedure = "dbo.MiniOfficeOrder_Update";
        private const string _deleteProcedure = "dbo.MiniOfficeOrder_Delete";
        private const string _selectByOrderIdProcedure = "dbo.MiniOfficeOrder_SelectByOrderId";

        public List<MiniOfficeOrder> GetAllMiniOfficeOrders()
        {
            using IDbConnection connection = ProvideConnection();

            return connection
                .Query<MiniOfficeOrder, MiniOffice, MiniOfficeOrder>
                    (_selectAllProcedure, (miniOfficeOrder, miniOffice) =>
                    {
                        miniOfficeOrder.MiniOffice = miniOffice;
                        return miniOfficeOrder;
                    })
                .ToList();
        }

        public MiniOfficeOrder GetMiniOfficeOrderById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            return connection
                .Query<MiniOfficeOrder, MiniOffice, MiniOfficeOrder>
                    (_selectByIdProcedure,
                    (miniOfficeOrder, miniOffice) =>
                    {
                        miniOfficeOrder.MiniOffice = miniOffice;
                        return miniOfficeOrder;
                    },
                    new
                    {
                        Id = id
                    },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public List<MiniOfficeOrder> GetMiniOfficeOrdersReferToOrder(int orderId)
        {
            using IDbConnection connection = ProvideConnection();

            return connection
                .Query<MiniOfficeOrder, MiniOffice, MiniOfficeOrder>
                    (_selectByOrderIdProcedure,
                    (miniOfficeOrder, miniOffice) =>
                    {
                        miniOfficeOrder.MiniOffice = miniOffice;
                        return miniOfficeOrder;
                    },
                    new { OrderId = orderId },
                    commandType: CommandType.StoredProcedure)
                .ToList();
        }

        public List<MiniOfficeOrder> GetMiniOfficeOrdersReferToOrder(Order order)
        {
            using IDbConnection connection = ProvideConnection();

            return connection
                 .Query<MiniOfficeOrder, MiniOffice, MiniOfficeOrder>
                    (_selectByOrderIdProcedure,
                    (miniOfficeOrder, miniOffice) =>
                    {
                        miniOfficeOrder.MiniOffice = miniOffice;
                        return miniOfficeOrder;
                    },
                    new { OrderId = order.Id },
                    commandType: CommandType.StoredProcedure)
                 .ToList();
        }

        public void Add(MiniOfficeOrder miniOfficeOrder)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(
                _insertProcedure,
                new
                {
                    MiniOfficeId = miniOfficeOrder.MiniOffice.Id,
                    OrderId = miniOfficeOrder.OrderId,
                    StartDate = miniOfficeOrder.StartDate,
                    EndDate = miniOfficeOrder.EndDate,
                    SubtotalPrice = miniOfficeOrder.SubtotalPrice
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdateMiniOfficeOrderById(MiniOfficeOrder miniOfficeOrder)
        {
            using IDbConnection connection = ProvideConnection();

            var affectedRows = connection.Execute(
                _updateProcedure,
                new
                {
                    Id = miniOfficeOrder.Id,
                    MiniOfficeId = miniOfficeOrder.MiniOffice.Id,
                    OrderId = miniOfficeOrder.OrderId,
                    StartDate = miniOfficeOrder.StartDate,
                    EndDate = miniOfficeOrder.EndDate,
                    SubtotalPrice = miniOfficeOrder.SubtotalPrice
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeleteMiniOfficeOrderById(int id)
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
