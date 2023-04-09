using System.Xml.Serialization;

namespace Toucan.Youcan.Data.Repositories
{
    public interface IDbRepository
    {
        T? Get<T>(int id) where T : class;
        IQueryable<T> GetAll<T>() where T : class;

        void Add<T>(T newEntity) where T : class;
        void AddRange<T>(IEnumerable<T> newEntity) where T : class;

        void Remove<T>(int id) where T : class;

        void Update<T>(int id) where T : class;
    }
}
