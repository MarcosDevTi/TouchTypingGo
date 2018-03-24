using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface IInstitutionAppService : IDisposable
    {
        void Add(InstitutionViewModel institution);
        IEnumerable<InstitutionViewModel> GetAll();
        void Update(InstitutionViewModel institution);
        InstitutionViewModel GetById(Guid id);
        InstitutionViewModel GetByIdWithAddress(Guid id);
        void Delete(Guid id);
    }
}
