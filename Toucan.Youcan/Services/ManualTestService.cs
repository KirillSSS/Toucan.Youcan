﻿using Toucan.Youcan.Models.Options;
using Toucan.Youcan.Models;
using Toucan.Youcan.Services.Abstractions;

namespace Toucan.Youcan.Services
{
    public class ManualTestService : ITestService
    {
        public string testDays(DateTime startDate, int frequency, DateTime start, DateTime end)
        {
            var option = new OptionsDay();

            option.StartDate = startDate;
            option.EndDate = startDate.AddYears(2);

            option.Frequency = frequency;

            return string.Join(", ", option.GetAllDays(start, end));
        }

        public string testWeeks(DateTime startDate, int frequency, DateTime start, DateTime end, HashSet<DayOfWeek> days)
        {
            var option = new OptionsWeek();

            option.StartDate = startDate;
            option.EndDate = startDate.AddYears(2);
            option.Frequency = frequency;
            option.Days = days;

            return string.Join(", ", option.GetAllDays(start, end));
        }

        public string testMonths(DateTime startDate, int frequency, DateTime start, DateTime end, HashSet<DayOfWeek> days)
        {
            var option = new OptionsWeek();

            option.StartDate = startDate;
            option.EndDate = startDate.AddYears(2);
            option.Frequency = frequency;
            option.Days = days;

            return string.Join(", ", option.GetAllDays(start, end));
        }

        public string testYears(DateTime startDate, int frequency, DateTime start, DateTime end, HashSet<DayOfWeek> days)
        {
            var option = new OptionsWeek();

            option.StartDate = startDate;
            option.EndDate = startDate.AddYears(2);
            option.Frequency = frequency;
            option.Days = days;

            return string.Join(", ", option.GetAllDays(start, end));
        }

        public string GetDate(int days)
        {
            return DateTime.Now.AddDays(days) + "";
        }
    }
}