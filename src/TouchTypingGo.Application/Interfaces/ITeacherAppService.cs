using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface ITeacherAppService : IDisposable
    {
        void Add(TeacherViewModel teacherViewModel);
        IEnumerable<TeacherViewModel> GetAll();
        TeacherViewModel GetById(Guid id);
        void Update(TeacherViewModel teacherViewModel);
        void Delete(Guid id);
    }
}
