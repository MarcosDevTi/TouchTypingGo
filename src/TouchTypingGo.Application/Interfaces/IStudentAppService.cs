using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface IStudentAppService : IDisposable
    {
        void Add(StudentViewModel student);
        IEnumerable<StudentViewModel> GetAll();
        StudentViewModel GetById(Guid id);
        void Updade(StudentViewModel student);
        void Delete(StudentViewModel student);
    }
}
