using System;


namespace CoCowork.DataLayer.Entities
{
    public class LaptopOrder : BaseOrder
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Laptop Laptop { get; set; }
        private double _amountMonths;



    }
}
