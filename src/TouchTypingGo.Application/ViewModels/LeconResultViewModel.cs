using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    public class LeconResultViewModel : IMapTo<LeconResult>, IMapFrom<LeconResult>
    {
        public int Try { get; private set; }
        public int Wpm { get; private set; }
        public int Time { get; private set; }
        public int Errors { get; private set; }
        public bool EhAuthenticated { get; private set; }
        public string ErrorKey { get; private set; }
        public int CourseId { get; private set; }
        public bool Active { get; private set; }
        public Guid LeconPresentationId { get; private set; }
        public virtual LeconPresentationViewModel LeconPresentation { get; private set; }
        public virtual ICollection<StudentViewModel> Students { get; private set; }
        public virtual ICollection<CourseViewModel> Courses { get; private set; }
    }
}
