// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System.ServiceProcess;

namespace Host
{
  public static class Program
  {
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    static void Main()
    {
      ServiceBase[] ServicesToRun;
      ServicesToRun = new ServiceBase[]
      {
                new Service1()
      };
      ServiceBase.Run(ServicesToRun);
    }
  }
}
