using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public ClientModel Client { get; set; }

        public List<PaymentModel> Payments { get; set; }

        public int TotalPrice { get; set; }

        public bool IsPaid { get; set; }

        public bool IsCancelled { get; set; }
    }
}
