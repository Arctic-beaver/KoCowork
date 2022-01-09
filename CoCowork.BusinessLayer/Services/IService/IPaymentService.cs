using CoCowork.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Services
{
    public interface IPaymentService
    {
        string Add(PaymentModel paymentModel);
    }
}
