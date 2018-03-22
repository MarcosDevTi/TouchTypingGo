using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Text;
using AutoMapper;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands;
using TouchTypingGo.Domain.Course.Commands.Course;

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
        public string Name { get;  set; }
        [Display(Name = "Data de finalização")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? LimitDate { get;  set; }
        public virtual ICollection<LessonPresentationViewModel> Lessons { get;  set; }      
        public virtual ICollection<StudentViewModel> Students { get;  set; }
        public Guid TeacherId { get; set; }
        [Display(Name = "Professor")]
        public virtual TeacherViewModel Teacher { get;  set; }
       
        public bool Deleted { get;  set; }
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CourseViewModel, Course>()
                .ForMember(x => x.Code, opt => opt.Ignore());

            configuration.CreateMap<Course, CourseViewModel>();
                //.ForMember(x=>x.Teacher, opt=>opt.Ignore())
                //.ForMember(dest => dest.Lessons,
                //    opts => opts.MapFrom(
                //        src => src.CourseLessonPresentations.Select(
                //            x=>x.LessonPresentation).Select(x=> 
                //                new LessonPresentationViewModel
                //                {
                //                   Id = x.Id,
                //                   Name = x.Name,
                //                   UserId = x.UserId,
                //                   Category = x.Category,
                //                   Text = x.Text,
                //                   FontSize = x.FontSize,
                //                   PrecisionReference = x.PrecisionReference,
                //                   SpeedReference = x.SpeedReference,
                //                   TimeReference = x.TimeReference
                //                }
                //    )));

            configuration.CreateMap<CourseViewModel, CourseAddCommand>()
                .ConstructUsing(x => new CourseAddCommand(x.Name, x.LimitDate, null));

            configuration.CreateMap<CourseViewModel, CourseUpdateCommand>()
                .ConstructUsing(x => new CourseUpdateCommand(x.Name, x.LimitDate));

            configuration.CreateMap<CourseViewModel, CourseDeleteCommand>()
                .ConstructUsing(x => new CourseDeleteCommand(x.Id));
        }
    }
}
