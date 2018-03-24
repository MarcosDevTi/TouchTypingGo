using AutoMapper;
using System;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.Keyboard;

namespace TouchTypingGo.Application.ViewModels
{
    public class KeyboardViewModel : IMapFrom<Keyboard>, IMapTo<Keyboard>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Lcid { get; set; }
        public string ValHtml { get; set; }
        public string KeyboardContent { get; set; }
        public bool Active { get; set; }
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<KeyboardViewModel, AddKeyboardCommand>()
                .ConstructUsing(x => new AddKeyboardCommand(x.Name, x.Lcid, x.ValHtml, x.KeyboardContent, x.Active));
        }
    }
}
