using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface ILessonResultAppService : IDisposable
    {
        void Add(LessonResultViewModel lessonResultViewModel);
        IEnumerable<LessonResultViewModel> GetAll();
        IEnumerable<LessonResultViewModel> GetByUserAuthenticated();
        LessonResultViewModel GetById(Guid id);
        void Delete(Guid id);
        SelectList LessonsPresentationsSelect();
    }
}
