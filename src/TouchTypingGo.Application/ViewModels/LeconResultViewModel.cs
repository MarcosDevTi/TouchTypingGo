using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.LeconResult;

namespace TouchTypingGo.Application.ViewModels
{
    public class LeconResultViewModel : IMapTo<LeconResult>, IMapFrom<LeconResult>, IHaveCustomMappings
    {
        public int Try { get; set; }
        public int Wpm { get; set; }
        public int Time { get; set; }
        public int Errors { get; set; }
        public bool EhAuthenticated { get; set; }
        public string ErrorKey { get; set; }
        public bool Active { get; set; }
        public Guid LeconPresentationId { get; set; }
        public virtual LeconPresentationViewModel LeconPresentation { get; set; }
        public virtual ICollection<StudentViewModel> Students { get; set; }
        public virtual ICollection<CourseViewModel> Courses { get; set; }
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<LeconResultViewModel, AddLeconResultCommand>()
                .ConstructUsing(l => new AddLeconResultCommand(
                    l.Try, l.Wpm, l.Time, l.Errors, l.EhAuthenticated, l.ErrorKey, l.Active, l.LeconPresentationId));
        }
    }
}
