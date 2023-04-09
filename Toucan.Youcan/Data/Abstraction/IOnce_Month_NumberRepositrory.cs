using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IOnce_Month_NumberRepositrory
    {
        //-----------------------------------------
        public Once_Month_Number? GetByIdGroup(int id);
        public IQueryable<Once_Month_Number> GetAll();
        //-----------------------------------------
        public int Add(Once_Month_Number newEntity);
        //-----------------------------------------
        public void Remove(Once_Month_Number user);
        //-----------------------------------------
        public void Update(Once_Month_Number user);
    }
}
