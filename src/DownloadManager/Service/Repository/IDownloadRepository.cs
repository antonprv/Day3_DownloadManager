// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System.Collections.Generic;

using Contracts.Dto;

namespace Service.Repository
{
  public interface IDownloadRepository
  {
    void Add(DownloadRecordDto record);
    List<DownloadRecordDto> GetAll();
  }
}
