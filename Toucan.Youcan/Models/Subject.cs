using Toucan.Youcan.Models.Abstractions;
using Toucan.Youcan.Models.Enums;

namespace Toucan.Youcan.Models
{
    public class Subject : Category
    {
        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public IOptions Frequency { get; set; }
    }
}
