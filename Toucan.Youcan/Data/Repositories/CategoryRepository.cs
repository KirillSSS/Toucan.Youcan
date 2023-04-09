using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class CategoryRepository : ICategoryRepositrory
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Category? Get(int id)
        {
            return _context.Set<Category>().Where(t => t.id == id).FirstOrDefault();
        }
        public Category? GetByDadId(int id)
        {
            return _context.Set<Category>().Where(t => t.dad_id == id).FirstOrDefault();
        }
        public Category? GetByOwnerId(int id)
        {
            return _context.Set<Category>().Where(t => t.owner_id == id).FirstOrDefault();
        }
        public Category? GetByCode(string code)
        {
            return _context.Set<Category>().Where(t => t.code.Equals(code)).FirstOrDefault();
        }
        public IQueryable<Category> GetAll()
        {
            return _context.Set<Category>().AsQueryable();
        }
        //-----------------------------------------
        public int Add(Category newEntity)
        {
            var entity = _context.Set<Category>().Add(newEntity);
            return entity.Entity.id;
        }
        //-----------------------------------------
        public void Remove(Category user)
        {
            _context.Set<Category>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Category user)
        {
            _context.Set<Category>().Update(user);
        }
    }
}
