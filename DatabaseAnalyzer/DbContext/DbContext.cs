using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Reflection;
using System.Text;
using DatabaseAnalyzer.Models;

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
        
        InitializeDatabase();
    }
    
    private void InitializeDatabase()
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
                command.CommandText = GenerateCreateTableSql<Connection>();
                command.ExecuteNonQuery();
                
                connection.Close();
            }
        }
    }
    
    private string GenerateCreateTableSql<T>() where T : class
    {
        var type = typeof(T);
        var tableName = type.Name + "s";

        var properties = type.GetProperties();
        var columns = new List<string>();
        
        var nullabilityContext = new NullabilityInfoContext();

        foreach (var prop in properties)
        {
            if (prop.Name.Equals("Id", StringComparison.OrdinalIgnoreCase) && prop.PropertyType == typeof(int))
            {
                columns.Add("Id INTEGER PRIMARY KEY AUTOINCREMENT");
                continue;
            }

            string columnName = prop.Name;
            string columnType = GetSqliteType(prop.PropertyType);
            
            var nullInfo = nullabilityContext.Create(prop);
            string nullability = (nullInfo.WriteState == NullabilityState.Nullable) ? "NULL" : "NOT NULL";

            columns.Add($"{columnName} {columnType} {nullability}");
        }

        var sb = new StringBuilder();
        sb.AppendLine($"CREATE TABLE IF NOT EXISTS {tableName} (");
        sb.AppendLine(string.Join(",\n    ", columns));
        sb.AppendLine(");");

        return sb.ToString();
    }
    
    private string GetSqliteType(Type propertyType)
    {
        Type underlyingType = Nullable.GetUnderlyingType(propertyType);
        if (underlyingType != null)
        {
            propertyType = underlyingType;
        }

        if (propertyType == typeof(int) || propertyType == typeof(bool))
        {
            return "INTEGER";
        }
        if (propertyType == typeof(string))
        {
            return "VARCHAR2";
        }
        if (propertyType == typeof(double) || propertyType == typeof(float) || propertyType == typeof(decimal))
        {
            return "REAL";
        }
        if (propertyType == typeof(DateTime))
        {
            return "DATETIME";
        }
        
        return "TEXT";
    }
    
    public SqliteConnection GetConnection()
    {
        var connection = new SqliteConnection(_connectionString);
        connection.Open();
        return connection;
    }
}