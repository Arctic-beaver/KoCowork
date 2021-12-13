using CoCowork.DataLayer.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    class MiniOfficeRepository
    {
        private const string _connectionString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProcedure = "dbo.MiniOffice_SelectAll";
        private const string _selectByIdProcedure = "dbo.MiniOffice_SelectById";
        private const string _insertProcedure = "dbo.MiniOffice_Insert";
        private const string _updateProcedure = "dbo.MiniOffice_Update";
        private const string _deleteProcedure = "dbo.MiniOffice_Delete";

        public List<MiniOffice> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

           return connection
                .Query<MiniOffice>
                (_selectAllProcedure)
                .Distinct()
                .ToList();
        }

        public MiniOffice GetMiniOfficeById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection
                .QueryFirstOrDefault<MiniOffice>(
                _selectByIdProcedure,
                new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public void Add(MiniOffice miniOffice)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.ExecuteScalar<MiniOffice>(
                _insertProcedure,
                new
                {
                    Name = miniOffice.Name,
                    AmountOfPlaces = miniOffice.AmountOfPlaces,
                    PricePerDay = miniOffice.PricePerDay,
                    IsActive = miniOffice.IsActive
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdateMiniOfficeById(int id, MiniOffice miniOffice)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var affectedRows = connection.ExecuteScalar<MiniOffice>(
                _updateProcedure,
                new
                {
                    Id = id,
                    Name = miniOffice.Name,
                    AmountOfPlaces = miniOffice.AmountOfPlaces,
                    PricePerDay = miniOffice.PricePerDay,
                    IsActive = miniOffice.IsActive
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeleteMiniOfficeById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.ExecuteScalar<MiniOffice>(
                _deleteProcedure,
                new
                {
                    Id = id
                },
                commandType: CommandType.StoredProcedure);
        }
    }
}
