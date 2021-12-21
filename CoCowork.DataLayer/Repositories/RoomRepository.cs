using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class RoomRepository : BaseRepository
    {
        private const string _selectAllProcedure = "dbo.Room_SelectAll";
        private const string _selectByIdProcedure = "dbo.Room_SelectById";
        private const string _insertProcedure = "dbo.Room_Insert";
        private const string _updateProcedure = "dbo.Room_Update";
        private const string _deleteProcedure = "dbo.Room_Delete";

        public List<Room> GetAll()
        {
            using IDbConnection connection = ProvideConnection();
            connection.Open();

            var result = connection.Query<Room>(_selectAllProcedure).ToList();

            return result;

        }

        public Room GetById(int id)
        {
            using IDbConnection connection = ProvideConnection();
            connection.Open();

            return connection.QueryFirstOrDefault(_selectByIdProcedure, new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public void Add(Room room)
        {
            using IDbConnection connection = ProvideConnection();
            connection.Open();
            connection.Execute(
                _insertProcedure,
                new
                {
                    Type = room.Type,
                    AmountOfPeople = room.AmountOfPeople,
                    PricePerHour = room.PricePerHour

                },
                commandType: CommandType.StoredProcedure);
        }

        public void Update(Room room)
        {
            using IDbConnection connection = ProvideConnection();
            connection.Open();
            connection.Execute(
                _updateProcedure,
                new
                {
                    Id = room.Id,
                    Type = room.Type,
                    AmountOfPeople = room.AmountOfPeople,
                    PricePerHour = room.PricePerHour
                },
                commandType: CommandType.StoredProcedure);
        }

        public void Delete(int id)
        {
            using IDbConnection connection = ProvideConnection();
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
