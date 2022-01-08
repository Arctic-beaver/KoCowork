using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public List<Payment> Payments { get; set; }

        public int ClientId { get; set; }

        public int TotalPrice { get; set; }

        public bool IsPaid { get; set; }

        public bool IsCancelled { get; set; }
    }
}
