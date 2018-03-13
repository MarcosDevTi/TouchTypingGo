using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    public class TeacherViewModel: IMapTo<Teacher>, IMapFrom<Teacher>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid CourseId { get; private set; }
        public virtual ICollection<CourseViewModel> Courses { get; set; }
    }
}
