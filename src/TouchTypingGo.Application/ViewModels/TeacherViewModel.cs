using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.Teacher;

namespace TouchTypingGo.Application.ViewModels
{
    [DisplayName("Teacher")]
    public class TeacherViewModel : IMapFrom<Teacher>, IMapTo<Teacher>, ICustomMappings
    {
        public Guid Id { get; set; }
        [Required, DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual ICollection<CourseViewModel> Courses { get; set; }
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<TeacherViewModel, TeacherAddCommand>()
                .ConstructUsing(x => new TeacherAddCommand(x.Id, x.Email, x.Name));
        }
    }
}
