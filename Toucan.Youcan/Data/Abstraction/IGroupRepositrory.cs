using Toucan.Youcan.Data.Entities;
namespace Toucan.Youcan.Data.Abstraction
{
    public interface IGroupRepositrory
    {
        //-----------------------------------------
        public Group? Get(int id);
        public IQueryable<Group> GetAll();
        //-----------------------------------------
        public int Add(Group newEntity);
        //-----------------------------------------
        public void Remove(Group user);
        //-----------------------------------------
        public void Update(Group user);
    }
}
