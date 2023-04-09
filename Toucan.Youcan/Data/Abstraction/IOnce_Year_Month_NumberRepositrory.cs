using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IOnce_Year_Month_NumberRepositrory
    {
        //-----------------------------------------
        public Once_Year_Number_Month? GetByGroupId(int id);
        public Once_Year_Number_Month? GetByMonthId(int id);
        public IQueryable<Once_Year_Number_Month> GetAll();
        //-----------------------------------------
        public bool Add(Once_Year_Number_Month newEntity);
        //-----------------------------------------
        public void Remove(Once_Year_Number_Month user);
        //-----------------------------------------
        public void Update(Once_Year_Number_Month user);
    }
}
