using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Entities
{
    public interface IOrder
    {
        public int Id { get; }
        public decimal SubtotalPrice { get; set; }


    }
}
