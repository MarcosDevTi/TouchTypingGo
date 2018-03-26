namespace TouchTypingGo.Application.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            AutoMapperConfigurator.LoadMapsFromCallerAndReferencedAssemblies();
        }
    }
}
