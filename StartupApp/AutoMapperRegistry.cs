using AutoMapper;
using AutoMapper.Mappers;
using StructureMap.Configuration.DSL;
using System.Collections.Generic;

namespace StartupApp
{
  class AutoMapperRegistry:Registry
  {
    public AutoMapperRegistry()
    {
      For<ConfigurationStore>().Singleton().Use<ConfigurationStore>().Ctor<IEnumerable<IObjectMapper>>()
       .Is(MapperRegistry.Mappers);
      For<IConfigurationProvider>().Use(x => x.GetInstance<ConfigurationStore>());
      For<IConfiguration>().Use(x => x.GetInstance<ConfigurationStore>());

      For<ITypeMapFactory>().Use<TypeMapFactory>();
      For<IMappingEngine>().Use(() => Mapper.Engine);
    }
  }
}
