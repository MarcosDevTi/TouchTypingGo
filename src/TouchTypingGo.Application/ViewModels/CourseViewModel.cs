using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    [DisplayName("Course")]
    public class CourseViewModel : ICustomMappings
    {
        public CourseViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        [Required, MinLength(2), MaxLength(150), DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("EndDate"), DataType(DataType.Date)]
        public DateTime? LimitDate { get; set; }
        public virtual ICollection<LessonPresentationViewModel> Lessons { get; set; }
        public virtual ICollection<StudentViewModel> Students { get; set; }
        public Guid TeacherId { get; set; }
        [DisplayName("Teacher")]
        public virtual TeacherViewModel Teacher { get; set; }

        public bool Deleted { get; set; }


        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Course, CourseViewModel>()
                .ForMember(dest => dest.Lessons, opt => opt.MapFrom(
                    src => src.CourseLessonPresentations.Select(l => l.LessonPresentation)));
        }
    }
}
