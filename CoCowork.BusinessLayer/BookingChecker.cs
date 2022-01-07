using CoCowork.BusinessLayer.Models;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer
{
    public class BookingChecker
    {
        public List<ItemModel> GetFree(DateTime StartTime, DateTime EndTime)
        {
            IsWorkplaceBooked(StartTime, EndTime);
            throw new NotImplementedException();
        }

        private bool IsWorkplaceBooked(DateTime StartTime, DateTime EndTime)
        {
            throw new NotImplementedException();
        }
    }
}
