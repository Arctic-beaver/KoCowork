using System.Collections.Generic;

namespace CoCowork.DataLayer.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public List<Payment> Payments { get; set; }

        public int ClientId { get; set; }

        public string ClientFirstName { get; set; }

        public string ClientLastName { get; set; }

        public decimal TotalPrice { get; set; }

        public bool IsPaid { get; set; }

        public bool IsCanceled { get; set; }
    }
}
