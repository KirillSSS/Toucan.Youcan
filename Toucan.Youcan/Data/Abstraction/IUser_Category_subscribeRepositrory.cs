using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IUser_Category_subscribeRepositrory
    {
        //-----------------------------------------
        public User_Category_Subscribe? GetByUserId(int id);
        public User_Category_Subscribe? GetByCategoryId(int id);
        public IQueryable<User_Category_Subscribe> GetAll();
        //-----------------------------------------
        public bool Add(User_Category_Subscribe newEntity);
        //-----------------------------------------
        public void Remove(User_Category_Subscribe user);
        //-----------------------------------------
        public void Update(User_Category_Subscribe user);
    }
}
