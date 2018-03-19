using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Commands.Course;
using TouchTypingGo.Domain.Course.Events.LeconPresentation;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Course.Commands.LeconPresentation
{
    public class LeconPresentationCommandHandler : CommandHandler,
        IHandler<LeconPresentationAddCommand>,
        IHandler<LeconPresentationDeleteCommand>
    {
        private readonly ILeconPresentationRepository _leconPresentationRepository;
        private readonly IBus _bus;

        public LeconPresentationCommandHandler(
            ILeconPresentationRepository leconPresentationRepository,
            IUnitOfWork uow,
            IBus bus,
            IDomainNotificationHandler<DomainDotification> notifications) : base(uow, bus, notifications)
        {
            _leconPresentationRepository = leconPresentationRepository;
            _bus = bus;
        }

        public void Handle(LeconPresentationAddCommand message)
        {
            var leconPresentation = Domain.Course.LeconPresentation.LeconPresentationFactory
                .NewLeconPresentationFactory(message.Text,
                    message.Category,
                    message.SpeedReference,
                    message.TimeReference,
                    message.PrecisionReference,
                    message.FontSize);

            _leconPresentationRepository.Add(leconPresentation);

            if (!Commit()) return;

            _bus.RaiseEvent(new LeconPresentationAddEvent( 
                message.Text, 
                message.Category, 
                message.SpeedReference, 
                message.TimeReference, 
                message.PrecisionReference, 
                message.FontSize));
        }

        private bool ExistingLeconPresentation(Guid id, string messageType)
        {
            if (_leconPresentationRepository.GetById(id) != null) return true;
            _bus.RaiseEvent(new DomainDotification(messageType, "Exercício não encontrado"));
            return false;
        }

        public void Handle(LeconPresentationDeleteCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
