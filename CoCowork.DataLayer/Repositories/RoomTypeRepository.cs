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
    class RoomTypeRepository
    {
        private const string _connString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProc = "dbo.RoomType_SelectAll";
        private const string _selectByIdProc = "dbo.RoomType_SelectById";
        private const string _insertProc = "dbo.RoomType_Insert";
        private const string _updateProc = "dbo.RoomType_Update";
        private const string _deleteProc = "dbo.RoomType_Delete";

        public List<RoomType> GetAllPayments()
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();
            var result = connection.Query<RoomType>(_selectAllProc).ToList();
            return result;
        }

        public RoomType GetRoomTypeById(int id)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            return connection
                .QueryFirstOrDefault<RoomType>(
                    _selectByIdProc,
                    new { Id = id },
                    commandType: CommandType.StoredProcedure);
        }

        public void Add(RoomType roomType)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.Execute(_insertProc,
                new
                {
                    Name = roomType.Name
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdateRoomTypeById(int id, RoomType roomType)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.Execute(_updateProc,
                new
                {
                    Id = id,
                    Name = roomType.Name
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeleteRoomTypeById(int id)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();
            connection.Execute(_deleteProc,
                        new { Id = id },
                        commandType: CommandType.StoredProcedure);
        }
    }
}
