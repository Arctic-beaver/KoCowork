using System;

namespace CoCowork.BusinessLayer.Models
{
    public class PaymentModel
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int OrderId { get; set; }

        public PaymentModel(decimal? amount, DateTime? paymentDate, int? orderId)
        {
            Amount = (decimal)amount;
            PaymentDate = (DateTime)paymentDate;
            OrderId = (int)orderId;
        }
    }
}
