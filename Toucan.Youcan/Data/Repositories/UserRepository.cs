using Microsoft.EntityFrameworkCore;
using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class UserRepository : IUsersRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Users? Get(int id)
        {
            return _context.Set<Users>().Where(t => t.id == id).FirstOrDefault();
        }
        public Users? GetByMail(string mail)
        {
            return _context.Set<Users>().Where(t => t.mail.Equals(mail)).FirstOrDefault();
        }
        public IQueryable<Users> GetAll()
        {
            return _context.Set<Users>().AsQueryable();
        }
        //-----------------------------------------
        public int Add(Users newEntity)
        {
            var entity = _context.Set<Users>().Add(newEntity);
            return entity.Entity.id;
        }
        //-----------------------------------------
        public void Remove(Users user)
        {
            _context.Set<Users>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Users user)
        {
            _context.Set<Users>().Update(user);
        }
        //-----------------------------------------
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
