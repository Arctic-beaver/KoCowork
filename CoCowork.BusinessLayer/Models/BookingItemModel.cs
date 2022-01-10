using System;

namespace CoCowork.BusinessLayer.Models
{
    public abstract class BookingItemModel : ItemModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double AmountOfBookingTime { get; set; }

        public double GetAmountDays()
        {
            return (EndDate - StartDate).TotalDays;
        }


        public double GetAmountMonth()
        {
            DateTime date1 = StartDate;
            DateTime date2 = EndDate;

            if (date1 > date2 || date1 == date2)
                return 0;

            double days = (date2 - date1).TotalDays;
            double month = 0;

            while (days != 0)
            {
                int inMnt = DateTime.DaysInMonth(date1.Year, date1.Month);
                if (days >= inMnt)
                {
                    days -= inMnt;
                    ++month;
                    date1 = date1.AddMonths(1);
                }
                else
                {
                    month += days / inMnt;
                    days = 0;
                }
            }

            return month;
        }

        public double GetAmountHours()
        {
            return (EndDate - StartDate).TotalHours;
        }
    }
}
