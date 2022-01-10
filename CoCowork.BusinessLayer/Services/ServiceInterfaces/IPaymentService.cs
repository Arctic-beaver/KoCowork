using CoCowork.BusinessLayer.Models;

namespace CoCowork.BusinessLayer.Services
{
    public interface IPaymentService
    {
        int Add(PaymentModel paymentModel);
    }
}
