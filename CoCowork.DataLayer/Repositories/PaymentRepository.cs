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
    class PaymentRepository
    {
        private const string _connString = "Server=(local);Integrated Security=True;Database=CoCowork.DB;";
        private const string _selectAllProc = "dbo.Payment_SelectAll";
        private const string _selectByIdProc = "dbo.Payment_SelectById";
        private const string _insertProc = "dbo.Payment_Insert";
        private const string _updateProc = "dbo.Payment_Update";
        private const string _deleteProc = "dbo.Payment_Delete";

        public List<Payment> GetAllPayments()
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();
            var result = connection.Query<Payment>(_selectAllProc).ToList();
            return result;
        }

        public Payment GetPaymentById(int id)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            return connection
                .QueryFirstOrDefault<Payment>(
                    _selectByIdProc,
                    new { Id = id },
                    commandType: CommandType.StoredProcedure);
        }

        public void Add(Payment payment)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.Execute(_insertProc,
                new
                {
                    Amount = payment.Amount,
                    PaymentDate = payment.PaymentDate,
                    OrderId = payment.OrderId
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdatePaymentById(int id, Payment payment)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();

            connection.Execute(_updateProc,
                new
                {
                    Id = id,
                    Amount = payment.Amount,
                    PaymentDate = payment.PaymentDate,
                    OrderId = payment.OrderId
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeletePaymentById(int id)
        {
            using var connection = new SqlConnection(_connString);
            connection.Open();
            connection.Execute(_deleteProc,
                        new { Id = id },
                        commandType: CommandType.StoredProcedure);
        }
    }
}
