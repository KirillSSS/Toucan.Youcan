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

        [HttpGet("getdate")]
        public string GetDate(int days)
        {
            return _manualTestService.GetDate(days);
        }   
    }
}
