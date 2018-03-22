using System;
using AutoMapper;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Institution.Commands.Institution;
using TouchTypingGo.Domain.Institution.Repository;

namespace TouchTypingGo.Application.Services
{
    public class InstitutionAppService : IInstitutionAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly IInstitutionRepository _institutionRepository;

        public InstitutionAppService(IBus bus, IMapper mapper, IInstitutionRepository institutionRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _institutionRepository = institutionRepository;
        }
        public void Add(InstitutionViewModel institution)
        {
           // _bus.SendCommand(new AddInstitutionCommand(institution.Name, institution.Address, institution.Name, institution.Email, institution.Phone));
        }

        public void Update(InstitutionViewModel institution)
        {
            throw new NotImplementedException();
        }

        public InstitutionViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
