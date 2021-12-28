namespace CoCowork.BusinessLayer.Models
﻿using CoCowork.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class PlaceModel : ItemModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsFixed { get; set; }
        public int AmountDays { get; set; }
        public string Type = "Место";
        public int Number { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PriceFixedPerDay { get; set; }
        public string Description { get; set; }
    }
}