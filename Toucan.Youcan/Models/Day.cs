namespace Toucan.Youcan.Models
{
    public class Day
    {
        public DateTime Date { get; set; }

        public List<Subject>? Subjects { get; set; }

        public Day(DateTime date)
        {
            Date = date;
            Subjects = new List<Subject>();
        }
        public Day(DateTime date, List<Subject> subjects)
        {
            Date = date;
            Subjects = subjects;
        }
        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }
    }
}
