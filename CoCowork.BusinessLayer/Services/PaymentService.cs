using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;

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

        public int Add(PaymentModel paymentModel)
        {
            Payment payment = CustomMapper.GetInstance().Map<Payment>(paymentModel);
            int id = _paymentRepository.Add(payment);

            var orderService = new OrderService();
            orderService.MarkAsPaidIfNeeded(payment.OrderId);

            return id;
        }
    }
}
