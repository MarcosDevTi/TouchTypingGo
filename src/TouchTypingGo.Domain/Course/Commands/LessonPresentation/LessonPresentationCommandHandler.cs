using System;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Events.LessonPresentation;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Course.Commands.LessonPresentation
{
    public class LessonPresentationCommandHandler : CommandHandler,
        IHandler<LessonPresentationAddCommand>,
        IHandler<LessonPresentationDeleteCommand>
    {
        private readonly ILessonPresentationRepository _lessonPresentationRepository;
        private readonly IBus _bus;

        public LessonPresentationCommandHandler(
            ILessonPresentationRepository lessonPresentationRepository,
            IUnitOfWork uow,
            IBus bus,
            IDomainNotificationHandler<DomainDotification> notifications) : base(uow, bus, notifications)
        {
            _lessonPresentationRepository = lessonPresentationRepository;
            _bus = bus;
        }

        public void Handle(LessonPresentationAddCommand message)
        {
            var lessonPresentation = Domain.Course.LessonPresentation.LessonPresentationFactory
                .NewlessonPresentationFactory(message.Name, message.Text,
                    message.Category,
                    message.SpeedReference,
                    message.TimeReference,
                    message.PrecisionReference,
                    message.FontSize, message.UserId);

            _lessonPresentationRepository.Add(lessonPresentation);

            if (!Commit()) return;

            _bus.RaiseEvent(new LessonPresentationAddEvent( 
                message.Text, 
                message.Category, 
                message.SpeedReference, 
                message.TimeReference, 
                message.PrecisionReference, 
                message.FontSize));
        }

        private bool ExistinglessonPresentation(Guid id, string messageType)
        {
            if (_lessonPresentationRepository.GetById(id) != null) return true;
            _bus.RaiseEvent(new DomainDotification(messageType, "Exercício não encontrado"));
            return false;
        }

        public void Handle(LessonPresentationDeleteCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
