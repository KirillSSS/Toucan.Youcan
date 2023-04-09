using Toucan.Youcan.Data.Entities;

namespace Toucan.Youcan.Data.Abstraction
{
    public interface IType_repeatRepositrory
    {
        //-----------------------------------------
        public Type_Repeat? Get(int id);
        public IQueryable<Type_Repeat> GetAll();
        //-----------------------------------------
        public int Add(Type_Repeat newEntity);
        //-----------------------------------------
        public void Remove(Type_Repeat user);
    }
}
