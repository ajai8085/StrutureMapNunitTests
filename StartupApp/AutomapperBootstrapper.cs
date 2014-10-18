using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartupApp
{
  class AutomapperBootstrapper
  {

    private readonly IMappingEngine _mappingEngine;
    public AutomapperBootstrapper(IMappingEngine mappingEngine )
    {
      _mappingEngine = mappingEngine;
    }
    public void InitMappings()
    {
      //map.CreateMappings(Mapper.Configuration);
      //IConfiguration.CreateMap


      Mapper.AssertConfigurationIsValid();
    }
  }
}
