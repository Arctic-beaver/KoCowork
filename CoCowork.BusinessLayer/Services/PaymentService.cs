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
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService()
        {
            _paymentRepository = new PaymentRepository();
        }

        public PaymentService(IPaymentRepository fakePaymentRepository)
        {
            _paymentRepository = fakePaymentRepository;
        }

        public string Add(PaymentModel paymentModel)
        {
            Payment payment = CustomMapper.GetInstance().Map<Payment>(paymentModel);
            string result;
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
    }
}
