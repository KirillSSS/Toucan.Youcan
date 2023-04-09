using System.Collections.Generic;
using System;
using Toucan.Youcan.Models.Abstractions;

namespace Toucan.Youcan.Models.Options
{
    public class OptionsMonth : ParentOption
    {
        public int? DayNumber { get; set; }

        public DayOfWeek? Day { get; set; }

        public int WeekFrequency { get; set; } = 1;

        public bool IsExtendedMode { get; set; }

        override public List<DateTime> GetAllDays(DateTime start, DateTime end)
        {
            var result = new List<DateTime>();

            if (StartDate >= start)
                start = StartDate;

            if (EndDate != null && EndDate <= end)
                end = (DateTime)EndDate;

            var temp = start;

            if (IsExtendedMode && Day != null )
            {
                while (temp <= end)
                {
                    DateTime firstDayOfMonth = new DateTime(temp.Year, temp.Month, 1);
                    DateTime firstNeededDayOfWeek = firstDayOfMonth.AddDays(((DayOfWeek)Day - firstDayOfMonth.DayOfWeek + 7) % 7);

                    if (firstNeededDayOfWeek.Month < firstDayOfMonth.Month)
                        firstNeededDayOfWeek = firstNeededDayOfWeek.AddDays(7);

                    DateTime exactDayOfMonth = firstNeededDayOfWeek.AddDays((WeekFrequency-1) * 7);
                    
                    if (exactDayOfMonth <= end)
                        result.Add(exactDayOfMonth);

                    temp = temp.AddMonths(Frequency);
                }
            }
            else
            {
                while (temp <= end)
                {
                    if (temp.Day == DayNumber)
                    {
                        result.Add(temp);
                        temp = temp.AddMonths(Frequency);
                    }
                    else
                    {
                        temp = temp.AddDays(1);
                    }
                }
            }

            return result;
        }
    }
}
