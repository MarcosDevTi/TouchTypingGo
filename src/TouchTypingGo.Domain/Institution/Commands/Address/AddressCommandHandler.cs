using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Domain.Institution.Events.Address;
using TouchTypingGo.Domain.Institution.Repository;

namespace TouchTypingGo.Domain.Institution.Commands.Address
{
    public class AddressCommandHandler : CommandHandler,
        IHandler<AddAddressCommand>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IBus _bus;
        public AddressCommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainDotification> notifications, IAddressRepository addressRepository) : base(uow, bus, notifications)
        {
            _addressRepository = addressRepository;
            _bus = bus;
        }

        public void Handle(AddAddressCommand message)
        {
            var address = new Domain.Institution.Address(
                message.County, 
                message.City, 
                message.Street, 
                message.Number,
                message.ZipCode);

            _addressRepository.Add(address);

            if (!Commit()) return;
            _bus.RaiseEvent(new AddAddressEvent(
                message.County,
                message.City,
                message.Street,
                message.Number,
                message.ZipCode));
        }
    }
}
