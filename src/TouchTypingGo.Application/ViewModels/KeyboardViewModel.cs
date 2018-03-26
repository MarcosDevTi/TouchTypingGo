using AutoMapper;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.Keyboard;

namespace TouchTypingGo.Application.ViewModels
{
    [DisplayName("Keyboard")]
    public class KeyboardViewModel : IMapFrom<Keyboard>, IMapTo<Keyboard>
    {
        public Guid Id { get; set; }
        [Required, DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        public int Lcid { get; set; }
        [Required, MaxLength(10)]
        public string ValHtml { get; set; }
        [MaxLength(20)]
        public string KeyboardContent { get; set; }
        public bool Active { get; set; }
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<KeyboardViewModel, AddKeyboardCommand>()
                .ConstructUsing(x => new AddKeyboardCommand(x.Name, x.Lcid, x.ValHtml, x.KeyboardContent, x.Active));
        }
    }
}
