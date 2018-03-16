using System;
using TouchTypingGo.Domain.Core.Commands;

namespace TouchTypingGo.Domain.Course.Commands.Course
{
    public abstract class CourseCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Code { get; protected set; }
        public string Name { get; protected set; }
        public DateTime? LimitDate { get; protected set; }
        public Guid TeacherId { get; protected set; }
    }
}
