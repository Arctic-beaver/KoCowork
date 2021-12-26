﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : IItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PriceForOne { get; set; }
        public string Type = "Продукты";
    }
}