using Toucan.Youcan.Models.Abstractions;

namespace Toucan.Youcan.Models.Options
{
    public class ParentOption : IOptions
    {
        public int Frequency { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; } = DateTime.Now.AddYears(5);

        virtual public List<DateTime> GetAllDays(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
