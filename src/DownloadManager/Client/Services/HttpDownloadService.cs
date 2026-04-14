// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Client.Services
{
  public class HttpDownloadService
  {
    private static readonly HttpClient _httpClient = new HttpClient();

    private static readonly int _bufferSize = 81920; // 80 KB chunks

    public async Task<long> DownloadAsync(
        string url,
        string destinationPath,
        IProgress<int> progress,
        CancellationToken cancellationToken)
    {
      using (var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
      {
        response.EnsureSuccessStatusCode();

        long totalBytes = response.Content.Headers.ContentLength ?? -1;
        long downloadedBytes = 0;

        using (var contentStream = await response.Content.ReadAsStreamAsync())
        using (var fileStream = new System.IO.FileStream(destinationPath, System.IO.FileMode.Create))
        {
          var buffer = new byte[_bufferSize]; 
          int bytesRead;

          while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)) > 0)
          {
            await fileStream.WriteAsync(buffer, 0, bytesRead, cancellationToken);
            downloadedBytes += bytesRead;

            if (totalBytes > 0)
              progress.Report((int)(downloadedBytes * 100 / totalBytes));
          }
        }

        return downloadedBytes;
      }
    }
  }
}
