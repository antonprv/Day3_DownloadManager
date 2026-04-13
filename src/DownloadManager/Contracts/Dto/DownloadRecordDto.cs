// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System;
using System.Runtime.Serialization;

namespace Contracts.Dto
{
  [DataContract]
  public class DownloadRecordDto
  {
    [DataMember] public int Id { get; set; }
    [DataMember] public string Url { get; set; }
    [DataMember] public string FileName { get; set; }
    [DataMember] public long FileSizeBytes { get; set; }
    [DataMember] public DateTime DownloadedAt { get; set; }
    [DataMember] public bool Success { get; set; }
  }
}
