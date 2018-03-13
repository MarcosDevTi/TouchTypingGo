using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchTypingGo.Application.AutoMapper;

namespace TouchTypingGo.Site.Services
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            //NOTE: By default, the current project and all referenced projects will be scanned.
            //		You can customize this by passing in a lambda to filter the assemblies by name,
            //		like so:
            //HeroicAutoMapperConfigurator.LoadMapsFromCallerAndReferencedAssemblies(x => x.Name.StartsWith("YourPrefix"));
            AutoMapperConfigurator.LoadMapsFromCallerAndReferencedAssemblies();
            //If you run into issues with the maps not being located at runtime, try using this method instead: 
            //HeroicAutoMapperConfigurator.LoadMapsFromAssemblyContainingTypeAndReferencedAssemblies<SomeControllerOrTypeInYourWebProject>();
        }
    }
}
