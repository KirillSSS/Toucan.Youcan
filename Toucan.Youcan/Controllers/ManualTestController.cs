using Microsoft.AspNetCore.Mvc;
using Toucan.Youcan.Models;
using Toucan.Youcan.Services.Abstractions;

namespace Toucan.Youcan.Controllers
{
    public class ManualTestController
    {
        private readonly ITestService _manualTestService;

        public ManualTestController(ITestService manualTestService)
        {
            _manualTestService = manualTestService;
        }

        [HttpGet("getdate")]
        public string GetDate(int days)
        {
            return _manualTestService.GetDate(days);
        }

        [HttpGet("testdays")]
        public string TestDays(string startDate, int frequency, string start, string end)
        {
            DateTime.TryParse(startDate, out var sD);
            DateTime.TryParse(start, out var s);
            DateTime.TryParse(end, out var e);

            return _manualTestService.testDays(sD, frequency, s, e);
        }

        [HttpGet("testweeks")]
        public string TestWeeks(string startDate, int frequency, string start, string end, string days)
        {
            DateTime.TryParse(startDate, out var sD);
            DateTime.TryParse(start, out var s);
            DateTime.TryParse(end, out var e);

            return _manualTestService.testWeeks(sD, frequency, s, e, days.Split(',').Select(day => Enum.Parse<DayOfWeek>(day)).ToHashSet());
        }

        [HttpGet("testmonths")]
        public string TestMonths(string startDate, int frequency, string start, string end, int? dayNumber, string? day, int? weekFrequency, bool isExtendedMode)
        {
            DateTime.TryParse(startDate, out var sD);
            DateTime.TryParse(start, out var s);
            DateTime.TryParse(end, out var e);

            DayOfWeek? dayOfWeek;

            if (day != null)
                dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
            else
                dayOfWeek = null;

            return _manualTestService.testMonths(sD, frequency, s, e, dayNumber, dayOfWeek, weekFrequency, isExtendedMode);
        }

        [HttpGet("testyears")]
        public string TestYears(string startDate, string start, string end, int? dayNumber, int? monthFirst, int? weekNumber, string? day, int? monthSecond, bool isExtendedMode)
        {
            DateTime.TryParse(startDate, out var sD);
            DateTime.TryParse(start, out var s);
            DateTime.TryParse(end, out var e);

            DayOfWeek? dayOfWeek;
            MonthEnum? mF;
            WeekEnum? wN;
            MonthEnum? mS;

            if (day != null)
                dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
            else
                dayOfWeek = null;

            if (monthFirst != null)
                mF = (MonthEnum)monthFirst;
            else
                mF = null;

            if (weekNumber != null)
                wN = (WeekEnum)weekNumber;
            else
                wN = null;

            if (monthSecond != null)
                mS = (MonthEnum)monthSecond;
            else
                mS = null;

            return _manualTestService.testYears(sD, s, e, dayNumber, mF, wN, dayOfWeek, mS, isExtendedMode);
        }
    }
}
