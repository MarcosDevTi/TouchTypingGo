using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface ILeconResultAppService : IDisposable
    {
        void Add(LeconResultViewModel leconResultViewModel);
        IEnumerable<LeconResultViewModel> GetAll();
        LeconResultViewModel GetById(Guid id);
        void Delete(Guid id);
        SelectList LeconsPresentationsSelect();
    }
}
