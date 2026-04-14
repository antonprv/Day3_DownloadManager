// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System.Threading;

namespace Client.Models
{
  public class DownloadItem
  {
    public string FileName { get; set; }
    public string Domain { get; set; }
    public string Url { get; set; }
    public int Progress { get; set; }
    public string Status { get; set; }

    public CancellationTokenSource CancellationSource { get; } = new CancellationTokenSource();
  }
}
