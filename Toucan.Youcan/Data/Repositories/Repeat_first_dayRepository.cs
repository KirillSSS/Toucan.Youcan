using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class Repeat_first_dayRepository : IRepeat_first_dayRepositrory
    {
        private readonly DataContext _context;

        public Repeat_first_dayRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Repeat_first_day? GetByGroupId(int id)
        {
            return _context.Set<Repeat_first_day>().Where(t => t.id_group == id).FirstOrDefault();
        }
        public Repeat_first_day? GetByDayId(int id)
        {
            return _context.Set<Repeat_first_day>().Where(t => t.id_day == id).FirstOrDefault();
        }
        public IQueryable<Repeat_first_day> GetAll()
        {
            return _context.Set<Repeat_first_day>().AsQueryable();
        }
        //-----------------------------------------
        public bool Add(Repeat_first_day newEntity)
        {
            var entity = _context.Set<Repeat_first_day>().Add(newEntity);
            return true;
        }
        //-----------------------------------------
        public void Remove(Repeat_first_day user)
        {
            _context.Set<Repeat_first_day>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Repeat_first_day user)
        {
            _context.Set<Repeat_first_day>().Update(user);
        }
    }
}
