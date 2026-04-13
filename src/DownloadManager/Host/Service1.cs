// Created by Anton Piruev in 2026. 
// Any direct commercial use of derivative work is strictly prohibited.

using System.ServiceProcess;

namespace Host
{
  public partial class Service1 : ServiceBase
  {
    public Service1()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
    }

    protected override void OnStop()
    {
    }
  }
}
