using System;

namespace CoCowork.DataLayer.Entities
{
    public abstract class BookingBaseOrder : BaseOrder
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        

        


    }
}
