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
           
            var course = Course.CourseFactory.NewCourseFactory(message.Code, message.Name, message.LimitDate, message.TeacherId);
            if (!CouseValid(course)) return;
            // Validações de negócio

            //Persistência
            _courseRepository.Add(course);

            if (!Commit()) return;
            Console.WriteLine("Curso registrado com sucesso");
            _bus.RaiseEvent(new CourseRegisterEvent(course.Name, course.LimitDate));
        }

        public void Handle(CourseUpdateCommand message)
        {
            if (ExistingCourse(message.Id, message.MessageType)) return;

            var course = Course.CourseFactory.NewCourseFactory(message.Code, message.Name, message.LimitDate, message.TeacherId);

            if (!CouseValid(course)) return;

            _courseRepository.Update(course);
            if (Commit())
            {
                _bus.RaiseEvent(new CourseUpdateEvent(course.Code, course.Name, course.LimitDate));
            }
        }

        public void Handle(DeleteCourseCommand message)
        {
            if (ExistingCourse(message.Id, message.MessageType)) return;

            _courseRepository.Remove(message.Id);
            if (Commit())
            {
                _bus.RaiseEvent(new CourseDeleteEvent(message.Id));
            }
        }

        private bool CouseValid(Course course)
        {
            if (course.IsValid()) return true;
            ValidationsErrorNotification(course.ValidationResult);
            return false;
        }

        private bool ExistingCourse(Guid id, string messageType)
        {
            var course = _courseRepository.GetById(id);
            if (course != null) return true;
            _bus.RaiseEvent(new DomainDotification(messageType, "Evento não encontrado"));
            return false;
        }
    }
}
