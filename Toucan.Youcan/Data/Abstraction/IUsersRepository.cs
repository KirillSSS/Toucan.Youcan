using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IUsersRepository
    {
        public Users? Get(int id);
        public Users? GetByMail(string mail);
        public IQueryable<Users> GetAll();
        //-----------------------------------------
        public int Add(Users newEntity);
        //-----------------------------------------
        public void Remove(Users user);
        //-----------------------------------------
        public void Update(Users user);
        //-----------------------------------------
        public int SaveChanges();
    }
}
