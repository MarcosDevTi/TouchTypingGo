using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface ILessonListAppService
    {
        Dictionary<string, List<PreviewLessonViewModel>> PreviewLessonViewModels();
        AppViewModel GetById(Guid id);
        void CompleteLesson(AppViewModel appViewModel);
    }
}
