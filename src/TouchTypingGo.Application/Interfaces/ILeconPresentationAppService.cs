using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.Interfaces
{
    public interface IlessonPresentationAppService : IDisposable
    {
        void Add(LessonPresentationViewModel lessonPresentationViewModel);
        IEnumerable<LessonPresentationViewModel> GetAll();
        IEnumerable<LessonPresentationViewModel> GetByUserAuthenticated();
        LessonPresentationViewModel GetById(Guid id);
        void Delete(Guid id);
    }
}
