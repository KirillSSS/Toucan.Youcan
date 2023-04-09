using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class User_Category_SubscribeRepository : IUser_Category_subscribeRepositrory
    {
        private readonly DataContext _context;

        public User_Category_SubscribeRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public User_Category_Subscribe? GetByUserId(int id)
        {
            return _context.Set<User_Category_Subscribe>().Where(t => t.id_user == id).FirstOrDefault();
        }
        public User_Category_Subscribe? GetByCategoryId(int id)
        {
            return _context.Set<User_Category_Subscribe>().Where(t => t.id_category == id).FirstOrDefault();
        }
        public IQueryable<User_Category_Subscribe> GetAll()
        {
            return _context.Set<User_Category_Subscribe>().AsQueryable();
        }
        //-----------------------------------------
        public bool Add(User_Category_Subscribe newEntity)
        {
            var entity = _context.Set<User_Category_Subscribe>().Add(newEntity);
            return true;
        }
        //-----------------------------------------
        public void Remove(User_Category_Subscribe user)
        {
            _context.Set<User_Category_Subscribe>().Remove(user);
        }
        //-----------------------------------------
        public void Update(User_Category_Subscribe user)
        {
            _context.Set<User_Category_Subscribe>().Update(user);
        }
    }
}
