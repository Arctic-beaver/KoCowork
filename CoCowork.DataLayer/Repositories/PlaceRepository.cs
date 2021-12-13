﻿using CoCowork.DataLayer.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace CoCowork.DataLayer.Repositories
{
    class PlaceRepository
    {
        private const string _connectionString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProcedure = "dbo.Place_SelectAll";
        private const string _selectByIdProcedure = "dbo.Place_SelectById";
        private const string _insertProcedure = "dbo.Place_Insert";
        private const string _updateProcedure = "dbo.Place_Update";
        private const string _deleteProcedure = "dbo.Place_Delete";
        private const string _selectByMiniOfficeIdProcedure = "dbo.Place_SelectByMiniOfficeId";

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
                .Distinct()
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

        public List<Place> GetPlacesReferToMiniOffice(int miniOfficeId)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection
                .Query<Place, MiniOffice, Place>
                (_selectByMiniOfficeIdProcedure, 
                (place, miniOffice) =>
                {
                    place.MiniOffice = miniOffice;
                    return place;
                },
                new { MiniOfficeId = miniOfficeId },
                commandType: CommandType.StoredProcedure)
                .Distinct()
                .ToList();
        }

        public List<Place> GetPlacesReferToMiniOffice(MiniOffice miniOffice)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection
                 .Query<Place, MiniOffice, Place>
                 (_selectByMiniOfficeIdProcedure,
                 (place, miniOffice) =>
                 {
                     place.MiniOffice = miniOffice;
                     return place;
                 },
                 new { MiniOfficeId = miniOffice.Id},
                 commandType: CommandType.StoredProcedure)
                 .Distinct()
                 .ToList();
        }

        public void Add(Place place)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            connection.ExecuteScalar<Place>(
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

            var affectedRows = connection.ExecuteScalar<Place>(
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

            connection.ExecuteScalar<Place>(
                _deleteProcedure,
                new
                {
                    Id = id
                },
                commandType: CommandType.StoredProcedure);
        }
    }   
}