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
        private readonly IOrderRepository _orderRepository;

        public PaymentService()
        {
            _paymentRepository = new PaymentRepository();
            _orderRepository = new OrderRepository();
        }

        public PaymentService(IPaymentRepository fakePaymentRepository)
        {
            _paymentRepository = fakePaymentRepository;
        }

        public int Add(PaymentModel paymentModel)
        {
            Payment payment = CustomMapper.GetInstance().Map<Payment>(paymentModel);
            int id = _paymentRepository.Add(payment);


            return id;
        }
    }
}
