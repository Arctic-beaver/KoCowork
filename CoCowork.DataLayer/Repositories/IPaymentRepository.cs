using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface IPaymentRepository
    {
        void Add(Payment payment);
        void DeletePaymentById(int id);
        List<Payment> GetAllPayments();
        Payment GetPaymentById(int id);
        void UpdatePaymentById(Payment payment);
    }
}