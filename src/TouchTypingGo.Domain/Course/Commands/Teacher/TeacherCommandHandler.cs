using System;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Events.Teacher;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Course.Commands.Teacher
{
    public class TeacherCommandHandler : CommandHandler,
        IHandler<TeacherAddCommand>,
        IHandler<TeacherDeleteCommand>
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IBus _bus;

        public TeacherCommandHandler(IUnitOfWork uow,
            IBus bus,
            IDomainNotificationHandler<DomainDotification> notifications,
            ITeacherRepository teacherRepository) : base(uow, bus, notifications)
        {
            _teacherRepository = teacherRepository;
            _bus = bus;
        }

        public void Handle(TeacherAddCommand message)
        {
            var teacher = new Domain.Course.Teacher(message.Id, message.Name, message.Email);
            _teacherRepository.Add(teacher);

            if (!Commit()) return;

            _bus.RaiseEvent(new TeacherAddEvent(teacher.Name, teacher.Email));
        }

        public void Handle(TeacherDeleteCommand message)
        {
            if (!ExistingTeacher(message.Id, message.MessageType)) return;

            _teacherRepository.Delete(message.Id);

            if (!Commit()) return;
            _bus.RaiseEvent(new TeacherDeleteEvent(message.Id));
        }

        private bool ExistingTeacher(Guid id, string messageType)
        {
            var teacher = _teacherRepository.GetById(id);
            if (teacher != null) return true;
            _bus.RaiseEvent(new DomainDotification(messageType, "Professor não encontrado"));
            return false;
        }
    }
}
