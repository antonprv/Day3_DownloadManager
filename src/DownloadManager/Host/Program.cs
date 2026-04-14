// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System;
using System.ServiceProcess;

namespace Host
{
  public static class Program
  {
    static void Main(string[] args)
    {
      if (Array.IndexOf(args, "--console") >= 0)
      {
        var host = new WcfHostManager();
        host.Start();
        Console.WriteLine("WCF host started. Press any key to stop.");
        Console.ReadKey();
        host.Stop();
      }
      else
      {
        ServiceBase.Run(new FileDownloaderService());
      }
    }
  }
}
