using Toucan.Youcan.Models.Abstractions;

namespace Toucan.Youcan.Models.Options
{
    public class OptionsMonth : ParentOption
    {
        public int? DayNumber { get; set; }

        public DayOfWeek? Day { get; set; }

        public int? WeekFrequency { get; set; }

        public bool IsExtendedMode { get; set; }

        override public List<DateTime> GetAllDays(DateTime start, DateTime end)
        {
            var result = new List<DateTime>();

            if (StartDate >= start)
                start = StartDate;

            if (EndDate <= end)
                end = EndDate;

            var temp = start;

            if (IsExtendedMode)
            {








                DateTime currentDate = startDate; // temp
                List<DateTime> thirdSaturdays = new List<DateTime>(); //result

                while (currentDate /*temp*/ <= endDate /*end*/)
                {
                    DateTime currentMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
                    DateTime firstSaturday = currentMonth.AddDays((DayOfWeek.Saturday /*Day*/ - currentMonth.DayOfWeek + 7) % 7);
                    if (firstSaturday.Month < currentMonth.Month)
                    {
                        firstSaturday = firstSaturday.AddDays(7);
                    }
                    DateTime thirdSaturday = firstSaturday.AddDays(14);
                    if (thirdSaturday <= endDate)
                    {
                        thirdSaturdays.Add(thirdSaturday);
                    }
                    currentDate = currentDate.AddMonths(1);
                }

                return thirdSaturdays;









            }
            else
            {
                while (temp <= end)
                {
                    if (temp.Day == DayNumber)
                        result.Add(temp);

                    temp.AddDays(1);
                }
            }

            while (temp <= end)
            {
                if (Days.Contains(temp.DayOfWeek))
                    result.Add(temp);

                if (temp.DayOfWeek == DayOfWeek.Sunday)
                    temp.AddDays(7);

                temp.AddDays(1);
            }

            return result;
        }
    }
}
