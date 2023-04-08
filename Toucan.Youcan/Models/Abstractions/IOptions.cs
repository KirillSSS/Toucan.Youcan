namespace Toucan.Youcan.Models.Abstractions
{
    public interface IOptions
    {
        public int Frequency { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public List<DateTime> GetAllDays(DateTime startDate, DateTime endDate);
    }
}
