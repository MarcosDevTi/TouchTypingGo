using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;
using AutoMapper;
using TouchTypingGo.Application.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands;
using TouchTypingGo.Domain.Course.Commands.Course;

namespace TouchTypingGo.Application.ViewModels
{
    public class CourseViewModel : IMapTo<Course>, IMapFrom<Course>, IHaveCustomMappings
    {
        public CourseViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O código é obrigatório")]
        [MinLength(4, ErrorMessage = "O tamanho mínimo é {1}")]
        [MaxLength(8, ErrorMessage = "O tamanho máximo é {1}")]
        [Display(Name = "Código")]
        public string Code { get;  set; }
        [Required(ErrorMessage = "O código é obrigatório")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo é {1}")]
        [Display(Name = "Nome do Curso")]
        public string Name { get;  set; }
        [Display(Name = "Data de finalização")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime? LimitDate { get;  set; }
        public virtual ICollection<LeconPresentationViewModel> Lecons { get;  set; }      
        public virtual ICollection<StudentViewModel> Students { get;  set; }
        public Guid TeacherId { get; set; }
        [Display(Name = "Professor")]
        public virtual TeacherViewModel Teacher { get;  set; }
       
        public bool Deleted { get;  set; }
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<CourseViewModel, CourseAddCommand>()
                
                .ConstructUsing(x => new CourseAddCommand(x.Code, x.Name, x.LimitDate, Guid.NewGuid()));

            configuration.CreateMap<CourseViewModel, CourseUpdateCommand>()
                .ConstructUsing(x => new CourseUpdateCommand(x.Name, x.LimitDate));

            configuration.CreateMap<CourseViewModel, CourseDeleteCommand>()
                .ConstructUsing(x => new CourseDeleteCommand(x.Id));
        }
    }
}
