// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System.ServiceModel;

using Contracts;

using Service.Infrastructure;
using Service.Repository;
using Service.Services;

namespace Host
{
  public class WcfHostManager
  {
    private ServiceHost _host;

    private const string ConnectionString = "Data Source=downloads.db;";
    private const string ServiceAddress = "net.tcp://localhost:8090/FileDownloader";

    public void Start()
    {
      SQLitePCL.Batteries.Init();

      new DatabaseInitializer(ConnectionString).EnsureCreated();

      var repository = new DownloadRepository(ConnectionString);
      var downloadService = new DownloadService(repository);

      _host = new ServiceHost(downloadService);

      var binding = new NetTcpBinding();
      _host.AddServiceEndpoint(typeof(IDownloadService), binding, ServiceAddress);

      _host.Open();
    }

    public void Stop()
    {
      try { _host?.Close(); }
      catch { _host?.Abort(); }
    }
  }
}
