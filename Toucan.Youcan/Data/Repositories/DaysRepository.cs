using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class DaysRepository : IDaysRepositrory
    {
        private readonly DataContext _context;

        public DaysRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Days? Get(int id)
        {
            return _context.Set<Days>().Where(t => t.id == id).FirstOrDefault();
        }
        public IQueryable<Days> GetAll()
        {
            return _context.Set<Days>().AsQueryable();
        }
        //-----------------------------------------
        public int Add(Days newEntity)
        {
            var entity = _context.Set<Days>().Add(newEntity);
            return entity.Entity.id;
        }
        //-----------------------------------------
        public void Remove(Days user)
        {
            _context.Set<Days>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Days user)
        {
            _context.Set<Days>().Update(user);
        }
    }
}
