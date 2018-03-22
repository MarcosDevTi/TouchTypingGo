using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface IlessonResultAppService : IDisposable
    {
        void Add(LessonResultViewModel lessonResultViewModel);
        IEnumerable<LessonResultViewModel> GetAll();
        IEnumerable<LessonResultViewModel> GetByUserAuthenticated();
        LessonResultViewModel GetById(Guid id);
        void Delete(Guid id);
        SelectList lessonsPresentationsSelect();
    }
}
