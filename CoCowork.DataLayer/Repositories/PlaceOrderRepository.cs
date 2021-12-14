using CoCowork.DataLayer.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class PlaceOrderRepository
    {
        private const string _connectionString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProcedure = "dbo.PlaceOrder_SelectAll";
        private const string _selectByIdProcedure = "dbo.PlaceOrder_SelectById";
        private const string _insertProcedure = "dbo.PlaceOrder_Insert";
        private const string _updateProcedure = "dbo.PlaceOrder_Update";
        private const string _deleteProcedure = "dbo.PlaceOrder_Delete";
        private const string _selectByOrderIdProcedure = "dbo.PlaceOrder_SelectByOrderId";

        public List<PlaceOrder> GetAllPlaceOrders()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var place = new Place();
            var placeOrder = new PlaceOrder();

            return connection
                .Query<PlaceOrder, Place, PlaceOrder>
                    (_selectAllProcedure, (placeOrder, place) =>
                    {
                        placeOrder.Place= place;
                        return placeOrder;
                    })
                .Distinct()
                .ToList();
        }

        public PlaceOrder GetPlaceOrderById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var placeOrder = new PlaceOrder();
            var place = new Place();

            return connection
                .Query<PlaceOrder, Place, PlaceOrder>
                    (_selectByIdProcedure,
                    (placeOrder, place) =>
                    {
                        placeOrder.Place = place;
                        return placeOrder;
                    },
                    new
                    {
                        Id = id
                    },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public List<PlaceOrder> GetPlaceOrdersReferToOrder(int orderId)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection
                .Query<PlaceOrder, Place, PlaceOrder>
                    (_selectByOrderIdProcedure,
                    (placeOrder, place) =>
                    {
                        placeOrder.Place = place;
                        return placeOrder;
                    },
                    new { OrderId = orderId },
                    commandType: CommandType.StoredProcedure)
                .Distinct()
                .ToList();
        }

        public List<PlaceOrder> GetPlaceOrdersReferToOrder(Order order)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection
                 .Query<PlaceOrder, Place, PlaceOrder>
                    (_selectByOrderIdProcedure,
                    (placeOrder, place) =>
                    {
                        placeOrder.Place = place;
                        return placeOrder;
                    },
                    new { OrderId = order.Id },
                    commandType: CommandType.StoredProcedure)
                 .Distinct()
                 .ToList();
        }

        public void Add(PlaceOrder placeOrder)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.Execute(
                _insertProcedure,
                new
                {
                    PlaceId = placeOrder.Place.Id,
                    OrderId = placeOrder.OrderId,
                    StartDate = placeOrder.StartDate,
                    EndDate = placeOrder.EndDate,
                    SubtotalPrice = placeOrder.SubtotalPrice
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdatePlaceOrderById(int id, PlaceOrder placeOrder)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var affectedRows = connection.Execute(
                _updateProcedure,
                new
                {
                    Id = id,
                    PlaceId = placeOrder.Place.Id,
                    OrderId = placeOrder.OrderId,
                    StartDate = placeOrder.StartDate,
                    EndDate = placeOrder.EndDate,
                    SubtotalPrice = placeOrder.SubtotalPrice
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeletePlaceOrderById(int id)
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
