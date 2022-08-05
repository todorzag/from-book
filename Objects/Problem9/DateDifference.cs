using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    internal class WorkingDays
    {
        static private List<DateTime> holidays = new List<DateTime>
        {
            new DateTime(2022, 9, 6),
            new DateTime(2022, 10, 31)
        };

        public DateTime StartingDate { get; set; }

        public DateTime EndingDate { get; }

        public int Days { get; set; }

        public WorkingDays(string endingDate)
        {
            StartingDate = DateTime.Now.Date;
            EndingDate = (DateTime.Parse(endingDate)).Date;
            Days = 0;
        }

        public int CalculateWorkingDays()
        {
            while (StartingDate.Date != EndingDate.Date)
            {
                if (StartingDate.DayOfWeek != DayOfWeek.Sunday 
                    && StartingDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    Days++;
                }
                else if (holidays.Contains(StartingDate.Date))
                {
                    Days++;
                }

                StartingDate = StartingDate.AddDays(1);
            }

            return Days;
        }
    }
}
