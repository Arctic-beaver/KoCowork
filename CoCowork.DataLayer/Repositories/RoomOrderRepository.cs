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
    public class RoomOrderRepository
    {
        private const string _connectionString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProcedure = "dbo.RoomOrder_SelectAll";
        private const string _selectByIdProcedure = "dbo.RoomOrder_SelectById";
        private const string _insertProcedure = "dbo.RoomOrder_Insert";
        private const string _updateProcedure = "dbo.RoomOrder_Update";
        private const string _deleteProcedure = "dbo.RoomOrder_Delete";

        public List<RoomOrder> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var result = connection.Query<RoomOrder>(_selectAllProcedure).ToList();

            return result;

        }

        public RoomOrder GetById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection.QueryFirstOrDefault<RoomOrder>(_selectByIdProcedure, new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public void Add(RoomOrder roomorder)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.ExecuteScalar<RoomOrder>(
                _insertProcedure,
                new
                {
                    Id = roomorder.Id,
                    ClientId = roomorder.RoomId,
                    OrderId = roomorder.OrderId,
                    StartDate = roomorder.StartDate,
                    EndDate = roomorder.EndDate,
                    SubtotalPrice = roomorder.SubtotalPrice

                },
                commandType: CommandType.StoredProcedure);
            ;
        }
        public void Update(RoomOrder roomorder)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            connection.ExecuteScalar<RoomOrder>(
                _updateProcedure,
                new
                {
                    Id = roomorder.Id,
                    ClientId = roomorder.RoomId,
                    OrderId = roomorder.OrderId,
                    StartDate = roomorder.StartDate,
                    EndDate = roomorder.EndDate,
                    SubtotalPrice = roomorder.SubtotalPrice

                },
                commandType: CommandType.StoredProcedure);
            ;
        }
        public void Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.ExecuteScalar<RoomOrder>(
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
