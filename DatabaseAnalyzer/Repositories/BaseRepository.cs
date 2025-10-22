using Microsoft.Data.Sqlite;

namespace DatabaseAnalyzer.Repositories
{
    public abstract class BaseRepository
    {
        private readonly DbContext _dbContext;

        protected BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected SqliteConnection GetConnection()
        {
            return _dbContext.GetConnection();
        }
    }
}