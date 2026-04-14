// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System;
using System.Collections.Generic;

using Contracts.Dto;

using Microsoft.Data.Sqlite;

namespace Service.Repository
{

  public class DownloadRepository : IDownloadRepository
  {
    private readonly string _connectionString;

    public DownloadRepository(string connectionString)
    {
      _connectionString = connectionString;
    }

    public void Add(DownloadRecordDto record)
    {
      using (var connection = new SqliteConnection(_connectionString))
      {
        connection.Open();

        string sql = @"
                INSERT INTO DownloadHistory (Url, FileName, FileSizeBytes, DownloadedAt, Success)
                VALUES (@Url, @FileName, @FileSizeBytes, @DownloadedAt, @Success)";

        using (var cmd = new SqliteCommand(sql, connection))
        {
          cmd.Parameters.AddWithValue("@Url", record.Url);
          cmd.Parameters.AddWithValue("@FileName", record.FileName);
          cmd.Parameters.AddWithValue("@FileSizeBytes", record.FileSizeBytes);
          cmd.Parameters.AddWithValue("@DownloadedAt", record.DownloadedAt.ToString("o"));
          cmd.Parameters.AddWithValue("@Success", record.Success ? 1 : 0);
          cmd.ExecuteNonQuery();
        }
      }
    }

    public List<DownloadRecordDto> GetAll()
    {
      var result = new List<DownloadRecordDto>();

      using (var connection = new SqliteConnection(_connectionString))
      {
        connection.Open();

        string sql = "SELECT * FROM DownloadHistory ORDER BY DownloadedAt DESC";

        using (var cmd = new SqliteCommand(sql, connection))
        using (var reader = cmd.ExecuteReader())
        {
          while (reader.Read())
          {
            result.Add(new DownloadRecordDto
            {
              Id = reader.GetInt32(reader.GetOrdinal("Id")),
              Url = reader.GetString(reader.GetOrdinal("Url")),
              FileName = reader.GetString(reader.GetOrdinal("FileName")),
              FileSizeBytes = reader.GetInt64(reader.GetOrdinal("FileSizeBytes")),
              DownloadedAt = DateTime.Parse(reader.GetString(reader.GetOrdinal("DownloadedAt"))),
              Success = reader.GetInt32(reader.GetOrdinal("Success")) == 1
            });
          }
        }
      }

      return result;
    }
  }
}
