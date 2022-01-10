using CoCowork.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Tests
{
    public class PaymentTestData
    {
        public PaymentModel GetPaymentModelForTests()
        {
            var payment = new PaymentModel(456, DateTime.Now, 2);
            return payment;
        }
    }
}
