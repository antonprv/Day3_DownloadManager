// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System;
using System.Collections.Generic;
using System.ServiceModel;

using Contracts;
using Contracts.Dto;

namespace Client.Services
{
  public class WcfClientService : IDisposable
  {
    private readonly ChannelFactory<IDownloadService> _factory;

    private const string ServiceAddress = "net.tcp://localhost:8090/FileDownloader";

    public WcfClientService()
    {
      var binding = new NetTcpBinding();
      var address = new EndpointAddress(ServiceAddress);
      _factory = new ChannelFactory<IDownloadService>(binding, address);
    }

    public void LogDownload(DownloadRecordDto record)
    {
      ExecuteOnChannel(channel => channel.LogDownload(record));
    }

    public List<DownloadRecordDto> GetHistory()
    {
      List<DownloadRecordDto> result = null;
      ExecuteOnChannel(channel => { result = channel.GetHistory(); });
      return result;
    }

    private void ExecuteOnChannel(Action<IDownloadService> action)
    {
      var channel = _factory.CreateChannel();
      try
      {
        action(channel);
        ((IClientChannel)channel).Close();
      }
      catch
      {
        ((IClientChannel)channel).Abort();
        throw;
      }
    }

    public void Dispose()
    {
      try { _factory.Close(); }
      catch { _factory.Abort(); }
    }
  }
}
