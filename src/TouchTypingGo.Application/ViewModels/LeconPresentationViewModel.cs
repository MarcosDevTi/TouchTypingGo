using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.LessonPresentation;

namespace TouchTypingGo.Application.ViewModels
{
    public class LessonPresentationViewModel : IHaveCustomMappings
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [Display(Name = "Nome do Exercício")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O texto é obrigatório")]
        [Display(Name = "Texto do Exercício")]
        public string Text { get; set; }
        [Required(ErrorMessage = "A categoria é obrigatória")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo é {1}")]
        [MaxLength(20, ErrorMessage = "O tamanho máximo é {1}")]
        [Display(Name = "Categoria")]
        public string Category { get; set; }
        public int SpeedReference { get; set; }
        public int TimeReference { get; set; }
        public int PrecisionReference { get; set; }
        [Display(Name = "Tabanho da fonte")]
        public int FontSize { get; set; }
        public Guid? UserId { get; set; }
        //public virtual ICollection<CourseViewModel> Courses { get; private set; }
        public virtual ICollection<LessonResultViewModel> LessonResults { get; private set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<LessonPresentation, LessonPresentationViewModel>();

            configuration.CreateMap<LessonPresentationViewModel, LessonPresentation>()
                .ForMember(dest => dest.CourseLessonPresentations, opt => opt.Ignore());

            configuration.CreateMap<LessonPresentationViewModel, LessonPresentation>()
                .ForMember(x => x.CourseLessonPresentations, opt => opt.Ignore())
                .ForMember(x => x.LessonResults, opt => opt.Ignore());

            configuration.CreateMap<LessonPresentationViewModel, LessonPresentationAddCommand>()
                    .ConstructUsing(x => new LessonPresentationAddCommand(x.Name, x.Text, x.Category, x.SpeedReference,
                    x.TimeReference, x.PrecisionReference, x.FontSize, null));

        }
    }
}
