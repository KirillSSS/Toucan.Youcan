using Toucan.Youcan.Models;

namespace Toucan.Youcan.Services.Abstractions
{
    public interface IUserService
    {
        public User GetUser(UserLogin user);

        public string testDays(DateTime startDate, int frequency, DateTime start, DateTime end);

        public string testWeeks(DateTime startDate, int frequency, DateTime start, DateTime end, HashSet<DayOfWeek> days);

        public string GetDate(int days);
    }
}
