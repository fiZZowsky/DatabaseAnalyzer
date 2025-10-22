using DatabaseAnalyzer.Helpers;
using DatabaseAnalyzer.Models;
using System.Collections.Generic;

namespace DatabaseAnalyzer.Repositories
{
    public class ConnectionRepository : BaseRepository, IConnectionRepository
    {
        public ConnectionRepository(DbContext dbContext) : base(dbContext) { }

        public void Add(Connection connection)
        {
            using (var conn = GetConnection())
            {
                var command = conn.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Connections (Name, Hostname, Port, Username, Password, SID, ServiceName)
                    VALUES (@Name, @Hostname, @Port, @Username, @Password, @SID, @ServiceName);
                    
                    SELECT last_insert_rowid();
                ";

                command.Parameters.AddWithValue("@Name", connection.Name);
                command.Parameters.AddWithValue("@Hostname", connection.Hostname);
                command.Parameters.AddWithValue("@Port", connection.Port);
                command.Parameters.AddWithValue("@Username", connection.Username);
                command.Parameters.AddWithValue("@Password", EncryptionHelper.EncryptString(connection.Password));
                command.Parameters.AddWithValue("@SID", (object)connection.SID ?? DBNull.Value);
                command.Parameters.AddWithValue("@ServiceName", (object)connection.ServiceName ?? DBNull.Value);

                connection.Id = Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void Delete(int connectionId)
        {
            using (var conn = GetConnection())
            {
                var command = conn.CreateCommand();
                command.CommandText = "DELETE FROM Connections WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", connectionId);
                command.ExecuteNonQuery();
            }
        }

        public List<Connection> GetAll()
        {
            var connections = new List<Connection>();
            using (var connection = GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Name, Hostname, Port, Username, Password, SID, ServiceName FROM Connections";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        connections.Add(new Connection
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Hostname = reader.GetString(2),
                            Port = reader.GetInt32(3),
                            Username = reader.GetString(4),
                            Password = EncryptionHelper.DecryptString(reader.GetString(5)),
                            SID = reader.IsDBNull(6) ? null : reader.GetString(6),
                            ServiceName = reader.IsDBNull(7) ? null : reader.GetString(7)
                        });
                    }
                }
            }
            return connections;
        }

        public void Update(Connection connection)
        {
            using (var conn = GetConnection())
            {
                var command = conn.CreateCommand();
                command.CommandText = @"
                    UPDATE Connections SET
                        Name = @Name,
                        Hostname = @Hostname,
                        Port = @Port,
                        Username = @Username,
                        Password = @Password,
                        SID = @SID,
                        ServiceName = @ServiceName
                    WHERE Id = @Id;
                ";

                command.Parameters.AddWithValue("@Id", connection.Id);
                command.Parameters.AddWithValue("@Name", connection.Name);
                command.Parameters.AddWithValue("@Hostname", connection.Hostname);
                command.Parameters.AddWithValue("@Port", connection.Port);
                command.Parameters.AddWithValue("@Username", connection.Username);
                command.Parameters.AddWithValue("@Password", EncryptionHelper.EncryptString(connection.Password));
                command.Parameters.AddWithValue("@SID", (object)connection.SID ?? DBNull.Value);
                command.Parameters.AddWithValue("@ServiceName", (object)connection.ServiceName ?? DBNull.Value);

                command.ExecuteNonQuery();
            }
        }
    }
}