using Toucan.Youcan.Models.Abstractions;
using Toucan.Youcan.Models.Enums;

namespace Toucan.Youcan.Models.Options
{
    public class OptionsYear : IOptions
    {
        public int Frequency { get; set; }

        public DateTime DayNumber { get; set; }

        public DayOfWeekEnum Day { get; set; }

        public int WeekFrequency { get; set; }

        public bool IsExtendedMode { get; set; }

        public List<DateTime> GetAllDays(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
