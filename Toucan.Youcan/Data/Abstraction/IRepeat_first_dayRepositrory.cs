using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IRepeat_first_dayRepositrory
    {
        //-----------------------------------------
        public Repeat_first_day? GetByGroupId(int id);
        public Repeat_first_day? GetByDayId(int id);
        public IQueryable<Repeat_first_day> GetAll();
        //-----------------------------------------
        public bool Add(Repeat_first_day newEntity);
        //-----------------------------------------
        public void Remove(Repeat_first_day user);
        //-----------------------------------------
        public void Update(Repeat_first_day user);
    }
}
