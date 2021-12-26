using CoCowork.DataLayer.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class MiniOfficeOrderRepository
    {
        private const string _connectionString = "Server=80.78.240.16;User ID=student;Password=qwe!23;Database=CoCowork.DB;";
        private const string _selectAllProcedure = "dbo.MiniOfficeOrder_SelectAll";
        private const string _selectByIdProcedure = "dbo.MiniOfficeOrder_SelectById";
        private const string _insertProcedure = "dbo.MiniOfficeOrder_Insert";
        private const string _updateProcedure = "dbo.MiniOfficeOrder_Update";
        private const string _deleteProcedure = "dbo.MiniOfficeOrder_Delete";
        private const string _selectByOrderIdProcedure = "dbo.MiniOfficeOrder_SelectByOrderId";

        public List<MiniOfficeOrder> GetAllMiniOfficeOrders()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

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
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

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
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

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
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

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
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.Execute(
                _insertProcedure,
                new
                {
                    MiniOfficeId = miniOfficeOrder.MiniOffice.Id,
                    Order = miniOfficeOrder.Order,
                    StartDate = miniOfficeOrder.StartDate,
                    EndDate = miniOfficeOrder.EndDate,
                    SubtotalPrice = miniOfficeOrder.SubtotalPrice
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdateMiniOfficeOrderById(int id, MiniOfficeOrder miniOfficeOrder)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var affectedRows = connection.Execute(
                _updateProcedure,
                new
                {
                    Id = id,
                    MiniOfficeId = miniOfficeOrder.MiniOffice.Id,
                    Order = miniOfficeOrder.Order,
                    StartDate = miniOfficeOrder.StartDate,
                    EndDate = miniOfficeOrder.EndDate,
                    SubtotalPrice = miniOfficeOrder.SubtotalPrice
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeleteMiniOfficeOrderById(int id)
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
