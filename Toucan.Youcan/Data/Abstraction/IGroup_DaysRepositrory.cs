using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IGroup_DaysRepositrory
    {
        //-----------------------------------------
        public Group_Days? GetByGroupId(int id);
        public Group_Days? GetByDayId(int id);
        public IQueryable<Group_Days> GetAll();
        //-----------------------------------------
        public bool Add(Group_Days newEntity);
        //-----------------------------------------
        public void Remove(Group_Days user);
        //-----------------------------------------
        public void Update(Group_Days user);
    }
}
