using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DatabaseAnalyzer;
public class DbContext
{
    private readonly string _dbPath;
    private readonly string _connectionString;

    public DbContext()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        _dbPath = configuration["DataAccess:ConnectionString"];

        if (!Path.IsPathRooted(_dbPath))
            _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _dbPath);

        _connectionString = $"Data Source={_dbPath}";

        EnsureDatabaseExists();
    }

    private void EnsureDatabaseExists()
    {
        if (!File.Exists(_dbPath))
        {
            var dbDir = Path.GetDirectoryName(_dbPath);
            if (!string.IsNullOrEmpty(dbDir) && !Directory.Exists(dbDir))
            {
                Directory.CreateDirectory(dbDir);
            }

            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Connections (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Hostname TEXT NOT NULL,
                        Port INTEGER NOT NULL,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        SID TEXT NULL,
                        ServiceName TEXT NULL
                    );
                ";
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
    
    public SqliteConnection GetConnection()
    {
        var connection = new SqliteConnection(_connectionString);
        connection.Open();
        return connection;
    }
}