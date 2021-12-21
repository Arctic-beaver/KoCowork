using CoCowork.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer
{
    public class BookingChecker
    {
        public List<IItemModel> GetFree(DateTime StartTime, DateTime EndTime)
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
