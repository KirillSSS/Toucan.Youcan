using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class Type_RepeatRepository : IType_repeatRepositrory
    {
        private readonly DataContext _context;

        public Type_RepeatRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Type_Repeat? Get(int id)
        {
            return _context.Set<Type_Repeat>().Where(t => t.id == id).FirstOrDefault();
        }
        public IQueryable<Type_Repeat> GetAll()
        {
            return _context.Set<Type_Repeat>().AsQueryable();
        }
        //-----------------------------------------
        public int Add(Type_Repeat newEntity)
        {
            var entity = _context.Set<Type_Repeat>().Add(newEntity);
            return entity.Entity.id;
        }
        //-----------------------------------------
        public void Remove(Type_Repeat user)
        {
            _context.Set<Type_Repeat>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Type_Repeat user)
        {
            _context.Set<Type_Repeat>().Update(user);
        }
    }
}
