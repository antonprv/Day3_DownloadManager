// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using Microsoft.Data.Sqlite;

namespace Service.Infrastructure
{
  public class DatabaseInitializer
  {
    private readonly string _connectionString;

    public DatabaseInitializer(string connectionString)
    {
      _connectionString = connectionString;
    }

    public void EnsureCreated()
    {
      using (var connection = new SqliteConnection(_connectionString))
      {
        connection.Open();

        string sql = @"
                CREATE TABLE IF NOT EXISTS DownloadHistory (
                    Id            INTEGER PRIMARY KEY AUTOINCREMENT,
                    Url           TEXT    NOT NULL,
                    FileName      TEXT    NOT NULL,
                    FileSizeBytes INTEGER NOT NULL,
                    DownloadedAt  TEXT    NOT NULL,
                    Success       INTEGER NOT NULL
                )";

        using (var cmd = new SqliteCommand(sql, connection))
          cmd.ExecuteNonQuery();
      }
    }
  }
}
