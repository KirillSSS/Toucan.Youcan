using Toucan.Youcan.Models.Abstractions;

namespace Toucan.Youcan.Models
{
    public class Subject : Category
    {
        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public IOptions Frequency { get; set; }
    }
}
