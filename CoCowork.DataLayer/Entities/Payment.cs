using System;

namespace CoCowork.DataLayer.Entities
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int OrderId { get; set; }
    }
}
