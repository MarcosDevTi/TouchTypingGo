using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Domain.Institution.Events.Institution;
using TouchTypingGo.Domain.Institution.Repository;

namespace TouchTypingGo.Domain.Institution.Commands.Institution
{
    public class InstitutionCommandHandler : CommandHandler,
        IHandler<AddInstitutionCommand>
    {
        private readonly IInstitutionRepository _institutionRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IBus _bus;

        public InstitutionCommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainDotification> notifications, IInstitutionRepository institutionRepository, IAddressRepository addressRepository) : base(uow, bus, notifications)
        {
            _institutionRepository = institutionRepository;
            _addressRepository = addressRepository;
            _bus = bus;
        }

        public void Handle(AddInstitutionCommand message)
        {
            var institution = new Domain.Institution.Institution(
                message.Name, 
                message.Email, 
                message.Phone, 
                _addressRepository.GetById(message.AddressId));

            _institutionRepository.Add(institution);

            if (!Commit()) return;

            _bus.RaiseEvent(new AddInstitutionEvent(
                message.Name,
                message.Email,
                message.Phone,
                message.AddressId));
        }
    }
}
