using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public abstract class ItemModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public BookingChecker BookingChecker { get; set; }

        public abstract void Delete();
    }
}
