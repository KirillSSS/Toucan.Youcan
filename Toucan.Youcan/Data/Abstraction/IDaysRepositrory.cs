using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IDaysRepositrory
    {
        //-----------------------------------------
        public Days? Get(int id);
        public IQueryable<Days> GetAll();
        //-----------------------------------------
        public int Add(Days newEntity);
        //-----------------------------------------
        public void Remove(Days user);
        //-----------------------------------------
        public void Update(Days user);
    }
}
