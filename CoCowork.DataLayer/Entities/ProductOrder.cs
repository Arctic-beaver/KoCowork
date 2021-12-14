using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Entities
{
    public class ProductOrder
    {
        public int Id { get; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public int SubtotalPrice { get; set; }
    }
}
