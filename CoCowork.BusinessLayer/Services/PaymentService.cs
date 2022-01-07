using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Services
{
    public class PaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService()
        {
            _paymentRepository = new PaymentRepository();
        }

        public string Add(PaymentModel paymentModel)
        {
            Payment payment = CustomMapper.GetInstance().Map<Payment>(paymentModel);
            string result = string.Empty;
            try
            {
                _paymentRepository.Add(payment);
                result = "Success";
            } 
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public List<PaymentModel> GetPaymentsByOrderId(int orderId)
        {

        }
    }
}
