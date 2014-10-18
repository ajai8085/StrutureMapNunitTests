using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupApp
{
  class Program
  {
    static void Main(string[] args)
    {
      StructureMap.IContainer container = new StructureMap.Container(c => c.AddRegistry<DefaultRegistry>());

      AutomapperBootstrapper.InitMappings();
    }
  }
}
