using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class RoomOrderRepository : BaseRepository, IRoomOrderRepository
    {
        private const string _selectAllProcedure = "dbo.RoomOrder_SelectAll";
        private const string _selectByIdProcedure = "dbo.RoomOrder_SelectById";
        private const string _insertProcedure = "dbo.RoomOrder_Insert";
        private const string _updateProcedure = "dbo.RoomOrder_Update";
        private const string _deleteProcedure = "dbo.RoomOrder_Delete";

        public List<RoomOrder> GetAll()
        {
            using IDbConnection connection = ProvideConnection();
            return connection.Query<RoomOrder>(_selectAllProcedure).ToList();
        }

        public RoomOrder GetById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            return connection.Query<RoomOrder, Room, Order, RoomOrder>
                (_selectByIdProcedure,
                (roomOrder, room, order) =>
                {
                    roomOrder.Room = room;
                    roomOrder.Order = order;
                    return roomOrder;
                },
                new { Id = id },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public int Add(RoomOrder roomorder)
        {
            using IDbConnection connection = ProvideConnection();

            return connection.Execute(
                _insertProcedure,
                new
                {
                    OrderId = roomorder.Order.Id,
                    RoomId = roomorder.Room.Id,
                    StartDate = roomorder.StartDate,
                    EndDate = roomorder.EndDate,
                    SubtotalPrice = roomorder.SubtotalPrice
                },
                commandType: CommandType.StoredProcedure);
        }

        public void Update(RoomOrder roomorder)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(
                _updateProcedure,
                new
                {
                    Id = roomorder.Id,
                    ClientId = roomorder.Room,
                    OrderId = roomorder.Order,
                    StartDate = roomorder.StartDate,
                    EndDate = roomorder.EndDate,
                    SubtotalPrice = roomorder.SubtotalPrice
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
