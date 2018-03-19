using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.Interfaces
{
    public interface ILeconPresentationAppService : IDisposable
    {
        void Add(LeconPresentationViewModel leconPresentationViewModel);
        IEnumerable<LeconPresentationViewModel> GetAll();
        LeconPresentationViewModel GetById(Guid id);
        void Delete(Guid id);
    }
}
