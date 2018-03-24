using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Institution.Commands.Address;
using TouchTypingGo.Domain.Institution.Repository;

namespace TouchTypingGo.Application.Services
{
    public class AddressAppService : IAddressAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly IAddressRepository _addressRepository;

        public AddressAppService(IBus bus, IMapper mapper, IAddressRepository addressRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _addressRepository = addressRepository;
        }
        public void Add(AddressViewModel address)
        {
            _bus.SendCommand(new AddAddressCommand(address.County, address.City, address.Street, address.Number, address.ZipCode));
        }

        public IEnumerable<AddressViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<AddressViewModel>>(_addressRepository.GetAll());
        }

        public AddressViewModel GetById(Guid id)
        {
            return _mapper.Map<AddressViewModel>(_addressRepository.GetById(id));
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _addressRepository.Dispose();
        }
    }
}
