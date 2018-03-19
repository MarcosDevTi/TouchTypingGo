using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Events.LeconResult;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Course.Commands.LeconResult
{
    public class LeconResultCommandHandler : CommandHandler,
        IHandler<AddLeconResultCommand>,
        IHandler<DeleteLeconResultCommand>
    {
        private readonly ILeconResultRepository _leconResultRepository;
        private readonly ILeconPresentationRepository _leconPresentationRepository;
        private readonly IBus _bus;
        public LeconResultCommandHandler(
            ILeconResultRepository leconResultRepository,
            IUnitOfWork uow, 
            IBus bus, 
            IDomainNotificationHandler<DomainDotification> notifications, ILeconPresentationRepository leconPresentationRepository) : base(uow, bus, notifications)
        {
            _leconResultRepository = leconResultRepository;
            _bus = bus;
            _leconPresentationRepository = leconPresentationRepository;
        }

        public void Handle(AddLeconResultCommand message)
        {
            var leconResult = Domain.Course.LeconResult.LeconResultFactory.NewLeconResultFactory(
                message.Try, 
                message.Wpm, 
                message.Time, 
                message.Errors, 
                message.EhAuthenticated, 
                message.ErrorKey,
                message.Active, 
                message.LeconPresentationId);
            leconResult.SetLeconPresentation(_leconPresentationRepository.GetById(message.Id));

            _leconResultRepository.Add(leconResult);

            if (!Commit()) return;

            _bus.RaiseEvent(new LeconResultAddEvent(
                message.Try, 
                message.Wpm, 
                message.Time, 
                message.Errors, 
                message.EhAuthenticated, 
                message.ErrorKey, 
                message.CourseId, 
                message.Active, 
                message.LeconPresentationId));
        }

        public void Handle(DeleteLeconResultCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
