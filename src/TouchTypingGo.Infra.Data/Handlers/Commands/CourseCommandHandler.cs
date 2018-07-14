using FluentValidation.Results;
using System;
using System.Linq;
using TouchTypingGo.Application.Cqrs.Command.Course;
using TouchTypingGo.Application.Cqrs.Query.Models.Course;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Domain.Core.Bus;
using TouchTypingGo.Domain.Core.Cqrs.Command;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Events.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Handlers.Commands
{
    public class CourseCommandHandler :
        ICommandHandler<CreateCourse>,
        ICommandHandler<CourseEditDetails>,
        ICommandHandler<DeleteCourse>
    {
        private readonly IUnitOfWork _uow;
        private readonly IBus _bus;
        private readonly IDomainNotificationHandler<DomainDotification> _notifications;
        private readonly IHelperService _helperService;
        private readonly TouchTypingGoContext _context;
        private readonly IUser _user;

        public CourseCommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainDotification> notifications, IHelperService helperService, TouchTypingGoContext context, IUser user)
        {
            _uow = uow;
            _bus = bus;
            _notifications = notifications;
            _helperService = helperService;
            _context = context;
            _user = user;
        }

        protected bool Commit()
        {
            if (_notifications.HasNotifications()) return false;
            var commandResponse = _uow.Commit();
            if (commandResponse.Success) return true;
            //TODO: Translate the texts for all languages
            _bus.RaiseEvent(new DomainDotification("Commit", "Ocorreu um erro ao salvar os dados no banco"));
            return false;
        }

        public void Handle(CreateCourse command)
        {
            var course = Domain.Course.Course.CourseFactory.NewCourseFactory(command.Name, command.LimitDate, _helperService.NewCode());

            if (_context.Teachers.Any(x => x.Id == _user.GetUderId()))
            {
                course.SetTeacher(_context.Teachers.Find(_user.GetUderId()));
                _context.Courses.Add(course);

                if (!Commit()) return;
                _bus.RaiseEvent(new CourseAddEvent(course.Name, course.LimitDate));
            }
            else
            {
                _bus.RaiseEvent(new DomainDotification(command.GetType().Name, "É possível inserir curso somente sendo professor!"));
            }
        }

        public void Handle(CourseEditDetails command)
        {

            if (ExistingCourse(command.Id)) return;

            var course = Course.CourseFactory.UpdateCourseFactory(command.Id, command.Name, command.LimitDate);

            if (!CouseValid(course)) return;

            _context.Courses.Update(course);

            if (Commit())
            {
                _bus.RaiseEvent(new CourseUpdateEvent(course.Code, course.Name, course.LimitDate));
            }
        }

        public void Handle(DeleteCourse command)
        {
            var course = _context.Courses.FirstOrDefault(x => x.Id == command.Id);
            if (ExistingCourse(course)) return;

            _context.Courses.Remove(course);

            if (!Commit()) return;
            _bus.RaiseEvent(new CourseDeleteEvent(command.Id));
        }

        private bool CouseValid(Domain.Course.Course course)
        {
            if (course.IsValid()) return true;
            ValidationsErrorNotification(course.ValidationResult);
            return false;
        }

        private bool ExistingCourse(Guid id)
        {
            var course = _context.Courses.Find(id);
            if (course != null) return true;
            _bus.RaiseEvent(new DomainDotification(nameof(course), "Evento não encontrado"));
            return false;
        }

        private bool ExistingCourse(Course course)
        {
            if (course != null) return true;
            _bus.RaiseEvent(new DomainDotification(nameof(course), "Evento não encontrado"));
            return false;
        }

        private void ValidationsErrorNotification(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
                _bus.RaiseEvent(new DomainDotification(error.PropertyName, error.ErrorMessage));
            }
        }
    }
}
