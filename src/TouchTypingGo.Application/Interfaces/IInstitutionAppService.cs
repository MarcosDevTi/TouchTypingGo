using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface IInstitutionAppService : IDisposable
    {
        void Add(InstitutionViewModel institution);
        void Update(InstitutionViewModel institution);
        InstitutionViewModel GetById(Guid id);
        void Delete(Guid id);
    }
}
