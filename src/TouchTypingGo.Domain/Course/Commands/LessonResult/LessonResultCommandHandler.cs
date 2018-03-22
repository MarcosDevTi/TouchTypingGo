using System;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Events.LessonResult;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Course.Commands.LessonResult
{
    public class LessonResultCommandHandler : CommandHandler,
        IHandler<AddLessonResultCommand>,
        IHandler<DeleteLessonResultCommand>
    {
        private readonly ILessonResultRepository _lessonResultRepository;
        private readonly ILessonPresentationRepository _lessonPresentationRepository;
        private readonly IBus _bus;
        public LessonResultCommandHandler(
            ILessonResultRepository lessonResultRepository,
            IUnitOfWork uow, 
            IBus bus, 
            IDomainNotificationHandler<DomainDotification> notifications, ILessonPresentationRepository lessonPresentationRepository) : base(uow, bus, notifications)
        {
            _lessonResultRepository = lessonResultRepository;
            _bus = bus;
            _lessonPresentationRepository = lessonPresentationRepository;
        }

        public void Handle(AddLessonResultCommand message)
        {
            var lessonResult = Domain.Course.LessonResult.LessonResultFactory.NewlessonResultFactory(
                message.Try, 
                message.Wpm, 
                message.Time, 
                message.Errors, 
                message.EhAuthenticated, 
                message.ErrorKey,
                message.Active, 
                message.LessonPresentationId,
                message.UserId);
            lessonResult.SetlessonPresentation(_lessonPresentationRepository.GetById(message.LessonPresentationId));

            _lessonResultRepository.Add(lessonResult);

            if (!Commit()) return;

            _bus.RaiseEvent(new LessonResultAddEvent(
                message.Try, 
                message.Wpm, 
                message.Time, 
                message.Errors, 
                message.EhAuthenticated, 
                message.ErrorKey, 
                message.CourseId, 
                message.Active, 
                message.LessonPresentationId));
        }

        public void Handle(DeleteLessonResultCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
