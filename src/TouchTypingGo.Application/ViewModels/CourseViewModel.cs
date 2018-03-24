using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    public class CourseViewModel : IHaveCustomMappings
    {
        public CourseViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string Code { get; set; }
        [Required(ErrorMessage = "O código é obrigatório")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo é {1}")]
        [Display(Name = "Name do Curso")]
        public string Name { get; set; }
        [Display(Name = "Data de finalização")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? LimitDate { get; set; }
        public virtual ICollection<LessonPresentationViewModel> Lessons { get; set; }
        public virtual ICollection<StudentViewModel> Students { get; set; }
        public Guid TeacherId { get; set; }
        [Display(Name = "Professor")]
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
