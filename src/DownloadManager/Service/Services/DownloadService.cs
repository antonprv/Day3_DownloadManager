// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System.Collections.Generic;
using System.ServiceModel;

using Contracts;
using Contracts.Dto;

using Service.Repository;

namespace Service.Services
{
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
  public class DownloadService : Contracts.IDownloadService
  {
    private readonly IDownloadRepository _repository;

    public DownloadService(IDownloadRepository repository)
    {
      _repository = repository;
    }

    public void LogDownload(DownloadRecordDto record)
    {
      _repository.Add(record);
    }

    public List<DownloadRecordDto> GetHistory()
    {
      return _repository.GetAll();
    }
  }
}
