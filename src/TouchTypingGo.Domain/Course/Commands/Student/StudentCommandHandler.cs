using System;
using System.Linq;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course.Commands.CommandHandlers;
using TouchTypingGo.Domain.Course.Events.Student;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Domain.Course.Commands.Student
{
    public class StudentCommandHandler : CommandHandler,
        IHandler<AddStudentCommand>,
        IHandler<DeleteStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IBus _bus;
        public StudentCommandHandler(
            IUnitOfWork uow, IBus bus,
            IDomainNotificationHandler<DomainDotification> notifications,
            IStudentRepository studentRepository) : base(uow, bus, notifications)
        {
            _studentRepository = studentRepository;
            _bus = bus;
        }

        public void Handle(AddStudentCommand message)
        {
            var emailRegistered = _studentRepository.Find(s => s.Email == message.Email);
            if (emailRegistered.Any())
            {
                //TODO: Translate the texts for all languages
                _bus.RaiseEvent(new DomainDotification(message.MessageType, "Email já cadastrado"));
            }

            var student = Domain.Course.Student.StudentFactory.NewStudentFactory(message.Id, message.Name, message.Email);
            _studentRepository.Add(student);

            if (!Commit()) return;
            _bus.RaiseEvent(new AddStudentEvent(message.Name, message.Email));

        }

        public void Handle(DeleteStudentCommand message)
        {
            var student = _studentRepository.GetById(message.Id);
            if (!ExistingStudent(message.Id, message.MessageType, student)) return;
        }

        public bool ExistingStudent(Guid id, string messageType, Domain.Course.Student student)
        {
            //TODO: Translate the texts for all languages
            if (student != null) return true;
            _bus.RaiseEvent(new DomainDotification(messageType, "Estudante não encontrado"));
            return false;
        }
    }
}
