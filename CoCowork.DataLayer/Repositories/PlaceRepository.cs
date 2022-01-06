using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace CoCowork.DataLayer.Repositories
{
    public class PlaceRepository : BaseRepository, IPlaceRepository
    {
        private const string _selectAllProcedure = "dbo.Place_SelectAll";
        private const string _selectByIdProcedure = "dbo.Place_SelectById";
        private const string _insertProcedure = "dbo.Place_Insert";
        private const string _updateProcedure = "dbo.Place_Update";
        private const string _deleteProcedure = "dbo.Place_Delete";
        private const string _selectByMiniOfficeIdProcedure = "dbo.Place_SelectByMiniOfficeId";
        private const string _selectThatNotInMiniOfficeProcedure = "dbo.Place_SelectThatNotInMiniOffice";

        public List<Place> GetAll()
        {
            using IDbConnection connection = ProvideConnection();

            return connection
                .Query<Place>
                    (_selectAllProcedure,
                    commandType: CommandType.StoredProcedure)
                .ToList();
        }

        public Place GetPlaceById(int id)
        {
            using IDbConnection connection = ProvideConnection();

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
            using IDbConnection connection = ProvideConnection();

            return connection
                 .Query<Place, MiniOffice, Place>
                    (_selectThatNotInMiniOfficeProcedure,
                    (place, miniOffice) =>
                    {
                        place.MiniOffice = miniOffice;
                        return place;
                    }, splitOn: "MiniOfficeId")
                 .ToList();
        }

        public int Add(Place place)
        {
            using IDbConnection connection = ProvideConnection();

            var result = connection.Execute(
                _insertProcedure,
                new
                {
                    Number = place.Number,
                    MiniOffice = place.MiniOffice.Id,
                    PricePerDay = place.PricePerDay,
                    PriceFixedPerDay = place.PriceFixedPerDay,
                    Description = place.Description
                },
                commandType: CommandType.StoredProcedure);
            return result;
        }

        public void UpdatePlaceById(Place place)
        {
            using IDbConnection connection = ProvideConnection();

            var affectedRows = connection.Execute(
                _updateProcedure,
                new
                {
                    Id = place.Id,
                    PricePerDay = place.PricePerDay,
                    PriceFixedPerDay = place.PriceFixedPerDay
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeletePlaceById(int id)
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
