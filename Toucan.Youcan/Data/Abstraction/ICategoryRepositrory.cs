using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface ICategoryRepositrory
    {
        //-----------------------------------------
        public Category? Get(int id);
        public Category? GetByDadId(int id);
        public Category? GetByOwnerId(int id);
        public Category? GetByCode(string code);
        public IQueryable<Category> GetAll();
        //-----------------------------------------
        public int Add(Category newEntity);
        //-----------------------------------------
        public void Remove(Category user);
        //-----------------------------------------
        public void Update(Category user);
    }
}
