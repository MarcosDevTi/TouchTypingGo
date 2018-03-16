using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using TouchTypingGo.Application.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    public class TeacherViewModel: IMapTo<Teacher>, IMapFrom<Teacher>, IHaveCustomMappings
    {
        public SelectList Teachers()
        {
            return new SelectList(TeacherList(), "Id", "Name");
        }

        private List<TeacherViewModel> TeacherList()
        {
            return new List<TeacherViewModel>
            {
                new TeacherViewModel
                {
                    Id = new Guid("a36a78e8-0df9-4371-af33-3364fe406ef9"),
                    Name = "Marcos Professor1"
                },
                new TeacherViewModel
                {
                    Id = new Guid("8e9c98eb-64b0-4f3b-8ece-02634722e6b0"),
                    Name = "Vera Professor2"
                },
                new TeacherViewModel
                {
                    Id = new Guid("f5000d5b-d5f2-47ab-9582-130b88ab68c8"),
                    Name = "Helena Professor3"
                }
            };
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid CourseId { get; private set; }
        public virtual ICollection<CourseViewModel> Courses { get; set; }
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
           
        }
    }
}
