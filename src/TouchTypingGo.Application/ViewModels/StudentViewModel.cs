using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TouchTypingGo.Application.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    [DisplayName("Student")]
    public class StudentViewModel : IMapFrom<Student>, IMapTo<Student>
    {
        public Guid Id { get; set; }
        [Required, DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        //public virtual ICollection<CourseViewModel> Course { get; private set; }
        //public virtual ICollection<LessonResultViewModel> LessonResults { get; private set; }
    }
}
