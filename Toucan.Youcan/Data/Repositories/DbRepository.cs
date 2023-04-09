namespace Toucan.Youcan.Data.Repositories
{
    public class DbRepository : IDbRepository
    {
        private readonly DataContext _context;

        public DbRepository(DataContext context)
        {
            _context = context;
        }
        // -------------------------------------------------
        public T? Get<T>(int id) where T : class
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }
        // -------------------------------------------------
        public void Add<T>(T newEntity) where T : class
        {
            throw new NotImplementedException();
        }

        public void AddRange<T>(IEnumerable<T> newEntity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(int id) where T : class
        {
            throw new NotImplementedException();
        }

        public void Update<T>(int id) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
