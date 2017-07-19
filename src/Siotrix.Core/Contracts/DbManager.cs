using Microsoft.EntityFrameworkCore;

namespace Siotrix
{
    public abstract class DbManager<T> where T : DbContext
    {
        // internal readonly T _db;
        public T _db;

        public DbManager(T db)
        {
            _db = db;
        }
    }
}
