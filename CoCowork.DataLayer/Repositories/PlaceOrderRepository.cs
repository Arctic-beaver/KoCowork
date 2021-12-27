using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class PlaceOrderRepository : BaseRepository, IPlaceOrderRepository
    {
        private const string _selectAllProcedure = "dbo.PlaceOrder_SelectAll";
        private const string _selectByIdProcedure = "dbo.PlaceOrder_SelectById";
        private const string _insertProcedure = "dbo.PlaceOrder_Insert";
        private const string _updateProcedure = "dbo.PlaceOrder_Update";
        private const string _deleteProcedure = "dbo.PlaceOrder_Delete";
        private const string _selectByOrderIdProcedure = "dbo.PlaceOrder_SelectByOrderId";

        public List<PlaceOrder> GetAllPlaceOrders()
        {
            using IDbConnection connection = ProvideConnection();

            return connection
                .Query<PlaceOrder, Place, PlaceOrder>
                    (_selectAllProcedure, (placeOrder, place) =>
                    {
                        placeOrder.Place = place;
                        return placeOrder;
                    })
                .ToList();
        }

        public PlaceOrder GetPlaceOrderById(int id)
        {
            using IDbConnection connection = ProvideConnection();

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
            using IDbConnection connection = ProvideConnection();

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
                .ToList();
        }

        public List<PlaceOrder> GetPlaceOrdersReferToOrder(Order order)
        {
            using IDbConnection connection = ProvideConnection();

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
                 .ToList();
        }

        public void Add(PlaceOrder placeOrder)
        {
            using IDbConnection connection = ProvideConnection();

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

        public void UpdatePlaceOrderById(PlaceOrder placeOrder)
        {
            using IDbConnection connection = ProvideConnection();

            var affectedRows = connection.Execute(
                _updateProcedure,
                new
                {
                    Id = placeOrder.Id,
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
