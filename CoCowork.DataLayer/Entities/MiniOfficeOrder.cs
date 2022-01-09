using System;

namespace CoCowork.DataLayer.Entities
{
    public class MiniOfficeOrder : BaseOrder
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MiniOffice MiniOffice { get; set; }
        private double _amountDays;

    }
}
