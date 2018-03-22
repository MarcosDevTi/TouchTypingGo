using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface IAddressAppService : IDisposable
    {
        void Add(AddressViewModel adressViewModel);
        IEnumerable<AddressViewModel> GetAll();
        AddressViewModel GetById(Guid id);
        void Delete(Guid id);
    }
}
