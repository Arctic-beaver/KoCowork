using CoCowork.BusinessLayer.Models;
using System;

namespace CoCowork.BusinessLayer.Tests
{
    public class PaymentTestData
    {
        public PaymentModel GetPaymentModelForTests()
        {
            var payment = new PaymentModel(456, DateTime.Now, 1);
            return payment;
        }
    }
}
