using System;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    public class StudentViewModel : IMapFrom<Student>, IMapTo<Student>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        //public virtual ICollection<CourseViewModel> Course { get; private set; }
        //public virtual ICollection<LessonResultViewModel> LessonResults { get; private set; }
    }
}
