using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class GroupRepository : IGroupRepositrory
    {
        private readonly DataContext _context;

        public GroupRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Group? Get(int id)
        {
            return _context.Set<Group>().Where(t => t.id == id).FirstOrDefault();
        }
        public IQueryable<Group> GetAll()
        {
            return _context.Set<Group>().AsQueryable();
        }
        //-----------------------------------------
        public int Add(Group newEntity)
        {
            var entity = _context.Set<Group>().Add(newEntity);
            return entity.Entity.id;
        }
        //-----------------------------------------
        public void Remove(Group user)
        {
            _context.Set<Group>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Group user)
        {
            _context.Set<Group>().Update(user);
        }
    }
}
