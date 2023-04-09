using Toucan.Youcan.Models.Abstractions;

namespace Toucan.Youcan.Models.Options
{
    public class OptionsYear : ParentOption
    {
        public new int Frequency = 1;

        public int? DayNumber { get; set; }

        public MonthEnum? MonthFirst { get; set;}

        public WeekEnum? WeekNumber { get; set; }
        public DayOfWeek? Day { get; set; }

        public MonthEnum? MonthSecond { get; set; }

        public bool IsExtendedMode { get; set; }

        override public List<DateTime> GetAllDays(DateTime start, DateTime end)
        {
            var result = new List<DateTime>();

            if (StartDate >= start)
                start = StartDate;

            if (EndDate != null && EndDate <= end)
                end = (DateTime)EndDate;



            if (!IsExtendedMode)
            {
                var temp = new DateTime(start.Year - 1, (int)MonthFirst, (int)DayNumber);

                while (temp <= end)
                {
                    if (temp >= start)
                        result.Add(temp);

                    temp = temp.AddYears(Frequency);
                }
            }
            else
            {
                var temp = new DateTime(start.Year, (int)MonthSecond, 1);
                

                while (temp <= end)
                {
                    var daysofweek = new List<DateTime>();
                    var temp2 = temp;
                    while (temp2.Month == (int)MonthSecond)
                    {
                        if (temp2.DayOfWeek == Day)
                            daysofweek.Add(temp2);
                        temp2 = temp2.AddDays(1);
                    }

                    if (WeekNumber == WeekEnum.Last)
                        result.Add(daysofweek[daysofweek.Count - 1]);
                    else
                        result.Add(daysofweek[(int)WeekNumber - 1]);

                    temp = temp.AddYears(1);
                }

            }
            return result;
        }
    }

}
