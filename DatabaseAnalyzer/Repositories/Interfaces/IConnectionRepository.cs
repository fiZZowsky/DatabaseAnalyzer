using DatabaseAnalyzer.Models;
using System.Collections.Generic;

namespace DatabaseAnalyzer.Repositories
{
    public interface IConnectionRepository
    {
        List<Connection> GetAll();
        void Add(Connection connection);
        void Update(Connection connection);
        void Delete(int connectionId);
    }
}