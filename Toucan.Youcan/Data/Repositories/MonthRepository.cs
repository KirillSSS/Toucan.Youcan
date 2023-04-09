using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class MonthRepository : IMonthRepositrory
    {
        private readonly DataContext _context;

        public MonthRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Month? Get(int id)
        {
            return _context.Set<Month>().Where(t => t.id == id).FirstOrDefault();
        }
        public IQueryable<Month> GetAll()
        {
            return _context.Set<Month>().AsQueryable();
        }
        //-----------------------------------------
        public int Add(Month newEntity)
        {
            var entity = _context.Set<Month>().Add(newEntity);
            return entity.Entity.id;
        }
        //-----------------------------------------
        public void Remove(Month user)
        {
            _context.Set<Month>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Month user)
        {
            _context.Set<Month>().Update(user);
        }
    }
}
