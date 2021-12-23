using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Entities
{
    public class ProductOrder : IOrder
    {
        public int Id { get; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public decimal SubtotalPrice { get; set; }
    }
}
