// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System.Collections.Generic;
using System.ServiceModel;

using Contracts.Dto;

namespace Contracts
{
  [ServiceContract]
  public interface IDownloadService
  {
    [OperationContract]
    void LogDownload(DownloadRecordDto record);

    [OperationContract]
    List<DownloadRecordDto> GetHistory();
  }
}
