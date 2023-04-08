using Microsoft.AspNetCore.Mvc;
using Toucan.Youcan.Models.Abstractions;

namespace Toucan.Youcan.Models.Options
{
    public class OptionsWeek : ParentOption
    {
        public HashSet<DayOfWeek> Days { get; set; }

        override public List<DateTime> GetAllDays(DateTime start, DateTime end)
        {
            var result = new List<DateTime>();

            if (StartDate >= start)
                start = StartDate;

            if (EndDate != null && EndDate <= end)
                end = (DateTime)EndDate;

            var temp = start;

            while (temp <= end)
            {
                if (Days.Contains(temp.DayOfWeek))
                    result.Add(temp);

                if (temp.DayOfWeek == DayOfWeek.Sunday)
                    temp = temp.AddDays((Frequency - 1) * 7);

                temp = temp.AddDays(1);
            }

            return result;
        }
    }
}
