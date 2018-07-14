using System;
using TouchTypingGo.Domain.Core.Cqrs.Command;

namespace TouchTypingGo.Application.Cqrs.Command.Course
{
    public class DeleteCourse : ICommand
    {
        public DeleteCourse(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
