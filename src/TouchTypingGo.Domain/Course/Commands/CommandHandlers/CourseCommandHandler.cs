using System;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Events;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Course.Commands.CommandHandlers
{
    public class CourseCommandHandler : CommandHandler,
        IHandler<CourseRegisterCommand>,
        IHandler<CourseUpdateCommand>,
        IHandler<DeleteCourseCommand>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IBus _bus;
        public CourseCommandHandler(
            ICourseRepository courseRepository,
            IUnitOfWork uow,
            IBus bus, IDomainNotificationHandler<DomainDotification> notification) : base(uow, bus, notification)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }
        public void Handle(CourseRegisterCommand message)
        {
            var course = new Domain.Course.Course(message.Code, message.Name, message.LimitDate);
            if (!course.IsValid())
            {
                ValidationsErrorNotification(course.ValidationResult);
                return;
            }
            // Validações de negócio

            //Persistência
            _courseRepository.Add(course);

            if (Commit())
            {
                Console.WriteLine("Curso registrado com sucesso");
                _bus.RiseEvent(new CourseRegisterEvent(course.Name, course.LimitDate));
            }
        }

        public void Handle(CourseUpdateCommand message)
        {
            throw new NotImplementedException();
        }

        public void Handle(DeleteCourseCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
