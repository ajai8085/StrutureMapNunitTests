using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace StartupApp
{
  class DefaultRegistry : Registry
  {
    public DefaultRegistry()
    {
      Scan(
        scan =>
        {
          scan.TheCallingAssembly();
          scan.WithDefaultConventions();
          scan.LookForRegistries();
          //scan.ConnectImplementationsToTypesClosing(typeof(ISyncHandler<>));

        });

    }
  }
}
