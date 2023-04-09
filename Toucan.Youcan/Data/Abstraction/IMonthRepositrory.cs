using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IMonthRepositrory
    {
        //-----------------------------------------
        public Month? Get(int id);
        public IQueryable<Month> GetAll();
        //-----------------------------------------
        public int Add(Month newEntity);
        //-----------------------------------------
        public void Remove(Month user);
        //-----------------------------------------
        public void Update(Month user);
    }
}
