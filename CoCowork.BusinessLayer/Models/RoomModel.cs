﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class RoomModel : IItemModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public BookingChecker BookingChecker { get; set; }
        public RoomType RoomType { get; set; }
        public int AmountOfPeople { get; set; }
        public decimal PricePerHour { get; set; }
    }
}
