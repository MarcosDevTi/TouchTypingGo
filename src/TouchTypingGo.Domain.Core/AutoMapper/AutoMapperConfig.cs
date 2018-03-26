namespace TouchTypingGo.Domain.Core.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            AutoMapperConfigurator.LoadMapsFromCallerAndReferencedAssemblies();
        }
    }
}
