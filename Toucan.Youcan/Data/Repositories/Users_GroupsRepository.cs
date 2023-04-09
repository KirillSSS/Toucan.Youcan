using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class Users_GroupsRepository : IUser_GroupsRepositrory
    {
        private readonly DataContext _context;

        public Users_GroupsRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Users_Groups? GetByUserId(int id)
        {
            return _context.Set<Users_Groups>().Where(t => t.id_user == id).FirstOrDefault();
        }
        public Users_Groups? GetByGroupId(int id)
        {
            return _context.Set<Users_Groups>().Where(t => t.id_group == id).FirstOrDefault();
        }
        public IQueryable<Users_Groups> GetAll()
        {
            return _context.Set<Users_Groups>().AsQueryable();
        }
        //-----------------------------------------
        public bool Add(Users_Groups newEntity)
        {
            var entity = _context.Set<Users_Groups>().Add(newEntity);
            return true;
        }
        //-----------------------------------------
        public void Remove(Users_Groups user)
        {
            _context.Set<Users_Groups>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Users_Groups user)
        {
            _context.Set<Users_Groups>().Update(user);
        }
    }
}
