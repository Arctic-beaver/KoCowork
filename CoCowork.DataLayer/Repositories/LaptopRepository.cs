using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace CoCowork.DataLayer.Repositories
{
    public class LaptopRepository
    {
        private const string _connString = "Server=80.78.240.16;User ID=student;Password=qwe!23;Database=CoCowork.DB;";//"Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProc = "dbo.Laptop_SelectAll";
        private const string _selectByIdProc = "dbo.Laptop_SelectById";
        private const string _insertProc = "dbo.Laptop_Insert";
        private const string _updateProc = "dbo.Laptop_Update";
        private const string _deleteProc = "dbo.Laptop_Delete";

        public List<Laptop> GetAll()
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            var result = connection.Query<Laptop>(_selectAllProc).ToList();

            return result;
        }
        public Laptop GetLaptopsById(int id)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            return connection
                .QueryFirstOrDefault<Laptop>(
                _selectByIdProc,
                new { Id = id },

                commandType: CommandType.StoredProcedure);
        }
        public void Add(Laptop laptop)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.Execute(_insertProc,
                new
                {
                    Name = laptop.Name,
                    Amount = laptop.Amount,
                    Price = laptop.Price,
                    Description = laptop.Description
                },

                commandType: CommandType.StoredProcedure);
        }
        public void UpdateLaptopById(int id, Laptop laptop)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.Execute(_updateProc,
                new
                {
                    Id = id,
                    Name = laptop.Name,
                    Amount = laptop.Amount,
                    Price = laptop.Price,
                    Description = laptop.Description
                },

                commandType: CommandType.StoredProcedure);
        }
        public void DeleteLaptopById(int id)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();
            connection.Execute(_deleteProc,
                        new { Id = id },
                        commandType: CommandType.StoredProcedure);
        }
    }
}
