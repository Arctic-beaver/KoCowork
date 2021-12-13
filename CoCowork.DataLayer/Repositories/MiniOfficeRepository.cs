using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Helpers;
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
        private const string _selectAllProcedure = "dbo.MiniOffice_SelectAll";
        private const string _selectByIdProcedure = "dbo.MiniOffice_SelectById";
        private const string _insertProcedure = "dbo.MiniOffice_Insert";
        private const string _updateProcedure = "dbo.MiniOffice_Update";
        private const string _deleteProcedure = "dbo.MiniOffice_Delete";

        public List<MiniOffice> GetAll()
        {
           var connection = DLHelpers.Connection();

           return connection
                .Query<MiniOffice>
                (_selectAllProcedure)
                .Distinct()
                .ToList();
        }

        public MiniOffice GetMiniOfficeById()
        {
            using var connection = DLHelpers.Connection();

            var miniOfficeDictionary = new Dictionary<int, MiniOffice>();


            return connection.Query<MiniOffice, Place, MiniOffice>(
            _selectByIdProcedure,
            (miniOffice, place) =>
            {

                if (!miniOfficeDictionary.TryGetValue(miniOffice.Id, out MiniOffice miniOfficeEntry))
                {
                    miniOfficeEntry = miniOffice;
                    miniOfficeEntry.Places = new List<Place>();
                    miniOfficeDictionary.Add(miniOfficeEntry.Id, miniOfficeEntry);
                }

                miniOfficeEntry.Places.Add(place);
                return miniOfficeEntry;
            },
            splitOn: "Id")
            .Distinct()
            .FirstOrDefault();
        }

        public void Add(MiniOffice miniOffice)
        {
            using var connection = DLHelpers.Connection();

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
            using var connection = DLHelpers.Connection();

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
            using var connection = DLHelpers.Connection();

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
