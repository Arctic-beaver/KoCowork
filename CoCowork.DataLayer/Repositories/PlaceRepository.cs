using CoCowork.DataLayer.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace CoCowork.DataLayer.Repositories
{
    public class PlaceRepository
    {
        private const string _connectionString = "Server=80.78.240.16;User ID=student;Password=qwe!23;Database=CoCowork.DB;";
        private const string _selectAllProcedure = "dbo.Place_SelectAll";
        private const string _selectByIdProcedure = "dbo.Place_SelectById";
        private const string _insertProcedure = "dbo.Place_Insert";
        private const string _updateProcedure = "dbo.Place_Update";
        private const string _deleteProcedure = "dbo.Place_Delete";
        private const string _selectThatNotInMiniOfficeProcedure = "dbo.Place_SelectThatNotInMiniOffice";
        
        public List<Place> GetAllPlaces()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection
                .Query<Place, MiniOffice, Place>
                    (_selectAllProcedure, (place, miniOffice) =>
                    {
                        place.MiniOffice = miniOffice;
                        return place;
                    })
                .ToList();
        }

        public Place GetPlaceById(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection
                .Query<Place, MiniOffice, Place>
                    (_selectByIdProcedure,
                    (place, miniOffice) =>
                    {
                    place.MiniOffice = miniOffice;
                    return place;
                    },
                    new
                    {
                        Id = id
                     },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public List<Place> GetPlacesThatNotInMiniOffice()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection
                 .Query<Place, MiniOffice, Place>
                    (_selectThatNotInMiniOfficeProcedure,
                    (place, miniOffice) =>
                    {
                        place.MiniOffice = miniOffice;
                        return place;
                    },
                    commandType: CommandType.StoredProcedure)
                 .ToList();
        }

        public void Add(Place place)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.Execute(
                _insertProcedure,
                new
                {
                    MiniOffice = place.MiniOffice.Id,
                    PricePerDay = place.PricePerDay,
                    PriceFixedPerDay = place.PriceFixedPerDay
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdatePlaceById(int id, Place place)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var affectedRows = connection.Execute( 
                _updateProcedure,
                new
                {
                    Id = id,
                    PricePerDay = place.PricePerDay,
                    PriceFixedPerDay = place.PriceFixedPerDay
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeletePlaceById(int id)
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
