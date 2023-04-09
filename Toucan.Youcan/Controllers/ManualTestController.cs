using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("testdays/{startDate}/{frequency}/{start}/{end}")]
        public string Test(string startDate, int frequency, string start, string end)
        {
            DateTime.TryParse(startDate, out var sD);
            DateTime.TryParse(start, out var s);
            DateTime.TryParse(end, out var e);

            return _manualTestService.testDays(sD, frequency, s, e);
        }

        [HttpGet("testweeks/{startDate}/{frequency}/{start}/{end}/{days}")]
        public string TestWeeks(string startDate, int frequency, string start, string end, string days)
        {
            DateTime.TryParse(startDate, out var sD);
            DateTime.TryParse(start, out var s);
            DateTime.TryParse(end, out var e);

            return _manualTestService.testWeeks(sD, frequency, s, e, days.Split(',').Select(day => Enum.Parse<DayOfWeek>(day)).ToHashSet());
        }

        [HttpGet("getdate")]
        public string GetDate(int days)
        {
            return _manualTestService.GetDate(days);
        }   
    }
}
