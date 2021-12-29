using System;

namespace CoCowork.DataLayer.Entities
{
    public class MiniOfficeOrder : BaseOrder
    {
        public MiniOffice MiniOffice { get; set; }
        public Order Order { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
