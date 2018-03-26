using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TouchTypingGo.Application.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.LessonPresentation;

namespace TouchTypingGo.Application.ViewModels
{
    [DisplayName("LessonPresentation")]
    public class LessonPresentationViewModel : ICustomMappings
    {
        public Guid Id { get; set; }
        [Required, DisplayName("Name")]
        public string Name { get; set; }
        [Required, Display(Name = "Text")]
        public string Text { get; set; }
        [Required, MinLength(2), MaxLength(20), Display(Name = "Category")]
        public string Category { get; set; }
        public int SpeedReference { get; set; }
        public int TimeReference { get; set; }
        public int PrecisionReference { get; set; }
        [Required, Display(Name = "FontSize")]
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
