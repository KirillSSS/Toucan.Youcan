using Microsoft.AspNetCore.Mvc;
using Toucan.Youcan.Models.Abstractions;
using Toucan.Youcan.Models.Options;

namespace Toucan.Youcan.Models
{
    public class OptionsDay : ParentOption
    {
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
                result.Add(temp);
                temp = temp.AddDays(Frequency);
            }

            return result;
        }
    }
}
