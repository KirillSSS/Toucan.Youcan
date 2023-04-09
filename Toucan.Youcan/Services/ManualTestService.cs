using Toucan.Youcan.Models.Options;
using Toucan.Youcan.Models;
using Toucan.Youcan.Services.Abstractions;

namespace Toucan.Youcan.Services
{
    public class ManualTestService : ITestService
    {
        public string GetDate(int days)
        {
            return DateTime.Now.AddDays(days) + "";
        }

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

        public string testMonths(DateTime startDate, int frequency, DateTime start, DateTime end, int? dayNumber, DayOfWeek? day, int? weekFrequency, bool isExtendedMode)
        {
            var option = new OptionsMonth();

            option.StartDate = startDate;
            option.EndDate = startDate.AddYears(2);
            option.Frequency = frequency;
            option.IsExtendedMode = isExtendedMode;

            if (isExtendedMode)
            {
                option.Day = day;
                option.WeekFrequency = (int)weekFrequency;
            }
            else
            {
                option.DayNumber = dayNumber;
            }

            return string.Join(", ", option.GetAllDays(start, end));
        }

        public string testYears(DateTime startDate, DateTime start, DateTime end, int? dayNumber, MonthEnum? monthFirst, WeekEnum? weekNumber, DayOfWeek? day, MonthEnum? monthSecond, bool isExtendedMode)
        {
            var option = new OptionsYear();

            option.StartDate = startDate;
            option.EndDate = startDate.AddYears(2);
            option.IsExtendedMode |= isExtendedMode;

            if (isExtendedMode)
            {
                option.WeekNumber = weekNumber;
                option.Day = day;
                option.MonthSecond = monthSecond;
            }
            else
            {
                option.DayNumber = dayNumber;
                option.MonthFirst = monthFirst;
            }

            return string.Join(", ", option.GetAllDays(start, end));
        }
    }
}
