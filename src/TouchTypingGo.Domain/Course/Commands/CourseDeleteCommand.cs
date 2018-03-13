using System;

namespace TouchTypingGo.Domain.Course.Commands
{
    public class CourseDeleteCommand : CourseCommand
    {
        public CourseDeleteCommand(Guid id)
        {
            Id = id;
            AggregateId = Id;
        }
    }
}
