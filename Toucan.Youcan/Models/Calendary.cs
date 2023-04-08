namespace Toucan.Youcan.Models
{
    public class Calendary
    {
        private DateTime[] GetWeekFromDate(DateTime date)
        {
            DateTime[] week = new DateTime[7];
            int delta = DayOfWeek.Monday - date.DayOfWeek;
            DateTime monday = date.AddDays(delta);
            for (int i = 0; i < 7; i++)
            {
                week[i] = monday.AddDays(i);
            }
            return week;
        }
        public Day[] GetWeek(DateTime Day, List<Subject> Subjects)
        {
            
            DateTime[] week = GetWeekFromDate(Day);

            Day[] days = new Day[7];

            for (int i = 0; i < days.Length; i++)
            {
                days[i] = new Day(week[i]);
            }

            for (int i = 0; i < Subjects.Count; i++)
            {
                List<DateTime> SubjDateTimes = Subjects[i].Frequency.GetAllDays(week[0], week[6]);
                for (int j = 0; i < SubjDateTimes.Count; i++)
                {
                    days[(SubjDateTimes[i] - week[0]).Days].AddSubject(Subjects[i]);
                    
                }
            }

            return days;
        }
    }
}
