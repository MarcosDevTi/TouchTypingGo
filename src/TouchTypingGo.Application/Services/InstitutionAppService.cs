using System;
using System.Collections.Generic;
using AutoMapper;
using FluentValidation;
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
            _bus.SendCommand(new AddInstitutionCommand(institution.Name, institution.Email, institution.Phone, institution.AddressId));
        }

        public IEnumerable<InstitutionViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<InstitutionViewModel>>(_institutionRepository.GetAll());
        }

        public void Update(InstitutionViewModel institution)
        {
            //throw new NotImplementedException();
        }

        public InstitutionViewModel GetById(Guid id)
        {
            var institution = _institutionRepository.GetById(id);
            var institutionViewModel = _mapper.Map<InstitutionViewModel>(institution);
            institutionViewModel.Address = _mapper.Map<AddressViewModel>(institution.Address);

            return institutionViewModel;
        }

        public InstitutionViewModel GetByIdWithAddress(Guid id)
        {
            
            var institution = _institutionRepository.GetByIdWithAddress(id);

            var institutionViewModel = new InstitutionViewModel
            {
                Id = institution.Id,
                Name = institution.Name,
                Address = new AddressViewModel
                {
                    Id = institution.Address.Id,
                    City = institution.Address.City,
                    County = institution.Address.County,
                    Number = institution.Address.Number,
                    Street = institution.Address.Street,
                    ZipCode = institution.Address.ZipCode
                },
                Email = institution.Email,
                AddressId = institution.AddressId,
                Phone = institution.Phone
            };


            return institutionViewModel;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _institutionRepository.Dispose();
        }
    }
}
