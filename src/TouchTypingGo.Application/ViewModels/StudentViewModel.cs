using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    public class StudentViewModel : IMapTo<Student>, IMapFrom<Student>
    {
        

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<CourseViewModel> Course { get; private set; }
        public virtual ICollection<LeconResultViewModel> LeconResults { get; private set; }
    }
}
