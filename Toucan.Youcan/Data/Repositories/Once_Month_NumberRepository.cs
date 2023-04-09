using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class Once_Month_NumberRepository : IOnce_Month_NumberRepositrory
    {
        private readonly DataContext _context;

        public Once_Month_NumberRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Once_Month_Number? GetByIdGroup(int id)
        {
            return _context.Set<Once_Month_Number>().Where(t => t.id_group == id).FirstOrDefault();
        }
        public IQueryable<Once_Month_Number> GetAll()
        {
            return _context.Set<Once_Month_Number>().AsQueryable();
        }
        //-----------------------------------------
        public int Add(Once_Month_Number newEntity)
        {
            var entity = _context.Set<Once_Month_Number>().Add(newEntity);
            return entity.Entity.id_group;
        }
        //-----------------------------------------
        public void Remove(Once_Month_Number user)
        {
            _context.Set<Once_Month_Number>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Once_Month_Number user)
        {
            _context.Set<Once_Month_Number>().Update(user);
        }
    }
}
