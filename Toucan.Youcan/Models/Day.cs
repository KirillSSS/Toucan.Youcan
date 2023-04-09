

namespace Toucan.Youcan.Models
{
    public class Day
    {
        public DateTime Date { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public List<Subject>? subjects { get; set; }
    }
}
