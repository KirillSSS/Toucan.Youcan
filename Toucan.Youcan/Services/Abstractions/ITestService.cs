namespace Toucan.Youcan.Services.Abstractions
{
    public interface ITestService
    {
        public string GetDate(int days);

        public string testDays(DateTime startDate, int frequency, DateTime start, DateTime end);

        public string testWeeks(DateTime startDate, int frequency, DateTime start, DateTime end, HashSet<DayOfWeek> days);

        public string testMonths(DateTime startDate, int frequency, DateTime start, DateTime end, int? dayNumber, DayOfWeek? day, int? weekFrequency, bool isExtendedMode);

        public string testYears(DateTime startDate, DateTime start, DateTime end, int? dayNumber, MonthEnum? monthFirst, WeekEnum? weekNumber, DayOfWeek? day, MonthEnum? monthSecond, bool isExtendedMode);

    }
}
