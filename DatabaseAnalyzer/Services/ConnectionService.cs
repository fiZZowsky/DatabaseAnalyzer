using DatabaseAnalyzer.Models;
using DatabaseAnalyzer.Repositories;
using System.Collections.Generic;

namespace DatabaseAnalyzer.Services
{
    public class ConnectionService : IConnectionService
    {
        private readonly IConnectionRepository _connectionRepository;

        public ConnectionService(IConnectionRepository connectionRepository)
        {
            _connectionRepository = connectionRepository;
        }

        public void DeleteConnection(int connectionId)
        {
            _connectionRepository.Delete(connectionId);
        }

        public List<Connection> GetConnections()
        {
            return _connectionRepository.GetAll();
        }

        public void SaveConnection(Connection connection)
        {
            if (connection.Id == 0)
            {
                _connectionRepository.Add(connection);
            }
            else
            {
                _connectionRepository.Update(connection);
            }
        }
    }
}