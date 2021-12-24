using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class MiniOfficeRepository : BaseRepository
    {
        private const string _selectAllProcedure = "dbo.MiniOffice_SelectAll";
        private const string _selectByIdProcedure = "dbo.MiniOffice_SelectById";
        private const string _insertProcedure = "dbo.MiniOffice_Insert";
        private const string _updateProcedure = "dbo.MiniOffice_Update";
        private const string _deleteProcedure = "dbo.MiniOffice_Delete";

        public List<MiniOffice> GetAll()
        {
            using IDbConnection connection = ProvideConnection();
            return connection.Query<MiniOffice>(_selectAllProcedure).ToList();
        }

        public MiniOffice GetMiniOfficeById(int id)
        {
            using IDbConnection connection = ProvideConnection();
            var miniOfficeDictionary = new Dictionary<int, MiniOffice>();

            return connection
                .Query<MiniOffice, Place, MiniOffice>(
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
                    new
                    {
                        Id = id
                    },
                    splitOn: "Id")
                .FirstOrDefault();
        }

        public void Add(MiniOffice miniOffice)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(
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

        public void UpdateMiniOfficeById(MiniOffice miniOffice)
        {
            using IDbConnection connection = ProvideConnection();

            var affectedRows = connection.Execute(
                _updateProcedure,
                new
                {
                    Id = miniOffice.Id,
                    Name = miniOffice.Name,
                    AmountOfPlaces = miniOffice.AmountOfPlaces,
                    PricePerDay = miniOffice.PricePerDay,
                    IsActive = miniOffice.IsActive
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeleteMiniOfficeById(int id)
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
