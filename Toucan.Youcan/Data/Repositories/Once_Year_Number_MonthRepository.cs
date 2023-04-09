using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Repositories
{
    public class Once_Year_Number_MonthRepository : IOnce_Year_Month_NumberRepositrory
    {
        private readonly DataContext _context;

        public Once_Year_Number_MonthRepository(DataContext context)
        {
            _context = context;
        }
        //-----------------------------------------
        public Once_Year_Number_Month? GetByGroupId(int id)
        {
            return _context.Set<Once_Year_Number_Month>().Where(t => t.id_group == id).FirstOrDefault();
        }
        public Once_Year_Number_Month? GetByMonthId(int id)
        {
            return _context.Set<Once_Year_Number_Month>().Where(t => t.id_month == id).FirstOrDefault();
        }
        public IQueryable<Once_Year_Number_Month> GetAll()
        {
            return _context.Set<Once_Year_Number_Month>().AsQueryable();
        }
        //-----------------------------------------
        public bool Add(Once_Year_Number_Month newEntity)
        {
            var entity = _context.Set<Once_Year_Number_Month>().Add(newEntity);
            return true;
        }
        //-----------------------------------------
        public void Remove(Once_Year_Number_Month user)
        {
            _context.Set<Once_Year_Number_Month>().Remove(user);
        }
        //-----------------------------------------
        public void Update(Once_Year_Number_Month user)
        {
            _context.Set<Once_Year_Number_Month>().Update(user);
        }
    }
}
