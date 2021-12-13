using CoCowork.DataLayer.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Repositories
{
    public class RoomRepository
    {
        private const string _connectionString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProcedure = "dbo.Room_SelectAll";
        private const string _selectByIdProcedure = "dbo.Room_SelectById";
        private const string _insertProcedure = "dbo.Room_Insert";
        private const string _updateProcedure = "dbo.Room_Update";
        private const string _deleteProcedure = "dbo.Room_Delete";

        public List<Room> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var result = connection.Query<Room>(_selectAllProcedure).ToList();

            return result;

        }

        public Room GetById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection.QueryFirstOrDefault<Room>(_selectByIdProcedure, new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public void Add(Room room)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.ExecuteScalar<Room>(
                _insertProcedure,
                new
                {
                    Id = room.Id,
                    Type = room.Type,
                    AmountOfPeople = room.AmountOfPeople,
                    PricePerHour = room.PricePerHour

                },
                commandType: CommandType.StoredProcedure);
            ;
        }
        public void Update(Room room)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.ExecuteScalar<Room>(
                _updateProcedure,
                new
                {
                    Id = room.Id,
                    Type = room.Type,
                    AmountOfPeople = room.AmountOfPeople,
                    PricePerHour = room.PricePerHour

                },
                commandType: CommandType.StoredProcedure);
            ;
        }
        public void Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.ExecuteScalar<Room>(
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
