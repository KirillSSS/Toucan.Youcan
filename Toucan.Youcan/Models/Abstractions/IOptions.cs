using Toucan.Youcan.Models.Enums;

namespace Toucan.Youcan.Models.Abstractions
{
    public interface IOptions
    {
        public List<DateTime> GetAllDays(DateTime startDate, DateTime endDate);
    }
}
