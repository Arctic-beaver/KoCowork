using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public string ClientFirstName { get; set; }

        public string ClientLastName { get; set; }

        public List<PaymentModel> Payments { get; set; }

        public decimal PaidSumm { get; set; }

        public decimal TotalPrice { get; set; }

        public bool IsPaid { get; set; }

        public bool IsCanceled { get; set; }
    }
}
