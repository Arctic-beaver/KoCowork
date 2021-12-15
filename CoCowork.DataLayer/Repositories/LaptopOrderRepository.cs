using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace CoCowork.DataLayer.Repositories
{
    public class LaptopOrderRepository
    {
        private const string _connString = "Server=80.78.240.16;User ID=student;Password=qwe!23;Database=CoCowork.DB;";//"Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProc = "dbo.LaptopOrder_SelectAll";
        private const string _selectByIdProc = "dbo.LaptopOrder_SelectById";
        private const string _selectByOrderIdProc = "dbo.LaptopOrder_SelectByOrderId";
        private const string _insertProc = "dbo.LaptopOrder_Insert";
        private const string _updateProc = "dbo.LaptopOrder_Update";
        private const string _deleteProc = "dbo.LaptopOrder_Delete";

        public List<LaptopOrder> GetAllLaptopOrders()
        {

            using var connection = new SqlConnection(_connString);
            connection.Open();

            var result = connection.Query<LaptopOrder>(_selectAllProc).ToList();

            return result;


        }
        public LaptopOrder GetLaptopOrderById(int id)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            return connection
                .Query<LaptopOrder, Laptop, LaptopOrder>
                (_selectByIdProc,
                (laptopOrder, laptop) =>
                {
                    laptopOrder.Laptop = laptop;
                    return laptopOrder;
                },
                new
                {
                    Id = id
                },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }
        public List<LaptopOrder> GetLaptopOrderByOrderId(int orderId)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            return connection
                .Query<LaptopOrder, Laptop, LaptopOrder>
                (_selectByOrderIdProc,
                (laptopOrder, laptop) =>
                {
                    laptopOrder.Laptop = laptop;
                    return laptopOrder;
                },
                new { OrderId = orderId },
                commandType: CommandType.StoredProcedure)
                .ToList();
        }
        public void Add(LaptopOrder laptopOrder)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.Execute(
                _insertProc,
                new
                {
                    LaptopId = laptopOrder.Laptop.Id,
                    OrderId = laptopOrder.OrderId,
                    StartDate = laptopOrder.StartDate,
                    EndDate = laptopOrder.EndDate,
                    SubtotalPrice = laptopOrder.SubtotalPrice
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdateMiniOfficeOrderById(int id, LaptopOrder laptopOrder)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            var affectedRows = connection.Execute(
                _updateProc,
                new
                {
                    Id = id,
                    LaptopId = laptopOrder.Laptop.Id,
                    OrderId = laptopOrder.OrderId,
                    StartDate = laptopOrder.StartDate,
                    EndDate = laptopOrder.EndDate,
                    SubtotalPrice = laptopOrder.SubtotalPrice
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeleteLaptopOrderById(int id)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.Execute(
                _deleteProc,
                new
                {
                    Id = id
                },
                commandType: CommandType.StoredProcedure);
        }
    }
}
