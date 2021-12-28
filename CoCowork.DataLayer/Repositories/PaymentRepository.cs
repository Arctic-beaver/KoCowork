using CoCowork.DataLayer.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoCowork.DataLayer.Repositories
{
    public class PaymentRepository : BaseRepository, IPaymentRepository
    {
        private const string _selectAllProc = "dbo.Payment_SelectAll";
        private const string _selectByIdProc = "dbo.Payment_SelectById";
        private const string _insertProc = "dbo.Payment_Insert";
        private const string _updateProc = "dbo.Payment_Update";
        private const string _deleteProc = "dbo.Payment_Delete";

        public List<Payment> GetAllPayments()
        {
            using IDbConnection connection = ProvideConnection();
            return connection.Query<Payment>(_selectAllProc).ToList();
        }

        public Payment GetPaymentById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            return connection
                .QueryFirstOrDefault<Payment>(
                    _selectByIdProc,
                    new { Id = id },
                    commandType: CommandType.StoredProcedure);
        }

        public void Add(Payment payment)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(_insertProc,
                new
                {
                    Amount = payment.Amount,
                    PaymentDate = payment.PaymentDate,
                    OrderId = payment.OrderId
                },
                commandType: CommandType.StoredProcedure);
        }

        public void UpdatePaymentById(Payment payment)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(_updateProc,
                new
                {
                    Id = payment.Id,
                    Amount = payment.Amount,
                    PaymentDate = payment.PaymentDate,
                    OrderId = payment.OrderId
                },
                commandType: CommandType.StoredProcedure);
        }

        public void DeletePaymentById(int id)
        {
            using IDbConnection connection = ProvideConnection();

            connection.Execute(_deleteProc,
                        new { Id = id },
                        commandType: CommandType.StoredProcedure);
        }
    }
}
