using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface IKeyboardAppService : IDisposable
    {
        void Add(KeyboardViewModel keyboardViewModel);
        IEnumerable<KeyboardViewModel> GetAll();
        KeyboardViewModel GetById(Guid id);
        void Delete(Guid id);
    }
}
