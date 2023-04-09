using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IAdminsRepositrory
    {
        //-----------------------------------------
        public Admins? GetByUserId(int id);
        public Admins? GetByCategoryId(int id);
        public IQueryable<Admins> GetAll();
        //-----------------------------------------
        public bool Add(Admins newEntity);
        //-----------------------------------------
        public void Remove(Admins user);
        //-----------------------------------------
        public void Update(Admins user);
    }
}
