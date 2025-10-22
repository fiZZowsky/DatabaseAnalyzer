using DatabaseAnalyzer.Models;
using System.Collections.Generic;

namespace DatabaseAnalyzer.Services
{
    public interface IConnectionService
    {
        List<Connection> GetConnections();
        void SaveConnection(Connection connection);
        void DeleteConnection(int connectionId);
    }
}