using AutoMapper;

namespace TouchTypingGo.Domain.Core.AutoMapper
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression configuration);
    }
}
