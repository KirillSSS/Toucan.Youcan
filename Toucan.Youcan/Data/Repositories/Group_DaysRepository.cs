using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class Group_DaysRepository : IGroup_DaysRepositrory
    {
        private readonly DataContext _context;

        public Group_DaysRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Group_Days? GetByGroupId(int id)
        {
            return _context.Set<Group_Days>().Where(t => t.id_group == id).FirstOrDefault();
        }
        public Group_Days? GetByDayId(int id)
        {
            return _context.Set<Group_Days>().Where(t => t.id_day == id).FirstOrDefault();
        }
        public IQueryable<Group_Days> GetAll()
        {
            return _context.Set<Group_Days>().AsQueryable();
        }
        //-----------------------------------------
        public bool Add(Group_Days newEntity)
        {
            var entity = _context.Set<Group_Days>().Add(newEntity);
            return true;
        }
        //-----------------------------------------
        public void Remove(Group_Days user)
        {
            _context.Set<Group_Days>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Group_Days user)
        {
            _context.Set<Group_Days>().Update(user);
        }
    }
}
