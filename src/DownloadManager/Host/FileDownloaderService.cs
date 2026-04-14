// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System.ServiceProcess;

namespace Host
{
  public class FileDownloaderService : ServiceBase
  {
    private readonly WcfHostManager _wcfHost = new WcfHostManager();

    public FileDownloaderService()
    {
      ServiceName = "FileDownloaderWcfHost";
    }

    protected override void OnStart(string[] args)
    {
      _wcfHost.Start();
    }

    protected override void OnStop()
    {
      _wcfHost.Stop();
    }
  }
}
