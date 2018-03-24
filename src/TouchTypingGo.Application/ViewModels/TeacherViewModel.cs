using AutoMapper;
using System;
using System.Collections.Generic;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.Teacher;

namespace TouchTypingGo.Application.ViewModels
{
    public class TeacherViewModel : IMapFrom<Teacher>, IMapTo<Teacher>, IHaveCustomMappings
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<CourseViewModel> Courses { get; set; }
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<TeacherViewModel, TeacherAddCommand>()
                .ConstructUsing(x => new TeacherAddCommand(x.Id, x.Email, x.Name));
        }
    }
}
