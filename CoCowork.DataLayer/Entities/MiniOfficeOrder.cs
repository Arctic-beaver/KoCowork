﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Entities
{
    public class MiniOfficeOrder
    {
        public int Id { get; set; }
        public MiniOffice MiniOffice { get; set; }
        public int OrderId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal SubtotalPrice { get; set; }
    }
}
