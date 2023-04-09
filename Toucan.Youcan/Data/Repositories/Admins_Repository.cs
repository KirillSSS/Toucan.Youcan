using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class Admins_Repository : IAdminsRepositrory
    {
        private readonly DataContext _context;

        public Admins_Repository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Admins? GetByUserId(int id)
        {
            return _context.Set<Admins>().Where(t => t.id_user == id).FirstOrDefault();
        }
        public Admins? GetByCategoryId(int id)
        {
            return _context.Set<Admins>().Where(t => t.id_category == id).FirstOrDefault();
        }
        public IQueryable<Admins> GetAll()
        {
            return _context.Set<Admins>().AsQueryable();
        }
        //-----------------------------------------
        public bool Add(Admins newEntity)
        {
            var entity = _context.Set<Admins>().Add(newEntity);
            return true;
        }
        //-----------------------------------------
        public void Remove(Admins user)
        {
            _context.Set<Admins>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Admins user)
        {
            _context.Set<Admins>().Update(user);
        }
    }
}
