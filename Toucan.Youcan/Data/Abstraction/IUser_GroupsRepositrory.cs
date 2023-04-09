using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IUser_GroupsRepositrory
    {
        //-----------------------------------------
        public Users_Groups? GetByUserId(int id);
        public Users_Groups? GetByGroupId(int id);
        public IQueryable<Users_Groups> GetAll();
        //-----------------------------------------
        public bool Add(Users_Groups newEntity);
        //-----------------------------------------
        public void Remove(Users_Groups user);
        //-----------------------------------------
        public void Update(Users_Groups user);
    }
}
