using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace CoCowork.DataLayer.Repositories
{
    public class LaptopRepository : BaseRepository, ILaptopRepository
    {
        private const string _selectAllProc = "dbo.Laptop_SelectAll";
        private const string _selectByIdProc = "dbo.Laptop_SelectById";
        private const string _insertProc = "dbo.Laptop_Insert";
        private const string _updateProc = "dbo.Laptop_Update";
        private const string _deleteProc = "dbo.Laptop_Delete";

        public List<Laptop> GetAll()
        {
            using IDbConnection connection = ProvideConnection();
            return connection.Query<Laptop>(_selectAllProc).ToList();
        }

        public Laptop GetLaptopsById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            return connection
                .QueryFirstOrDefault<Laptop>(
                _selectByIdProc,
                new { Id = id },

                commandType: CommandType.StoredProcedure);
        }

        public void Add(Laptop laptop)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(_insertProc,
                new
                {
                    Name = laptop.Name,
                    Number = laptop.Number,
                    Amount = laptop.Amount,
                    Price = laptop.PricePerMonth,
                    Description = laptop.Description
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdateLaptopById(Laptop laptop)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(_updateProc,
                new
                {
                    Id = laptop.Id,
                    Number = laptop.Number,
                    Name = laptop.Name,
                    Amount = laptop.Amount,
                    Price = laptop.PricePerMonth,
                    Description = laptop.Description
                },

                commandType: CommandType.StoredProcedure);
        }

        public void DeleteLaptopById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(_deleteProc,
                        new { Id = id },
                        commandType: CommandType.StoredProcedure);
        }

        public List<Laptop> GetAllLaptops()
        {
            throw new System.NotImplementedException();
        }
    }
}
