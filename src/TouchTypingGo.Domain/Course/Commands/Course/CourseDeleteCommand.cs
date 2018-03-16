using System;

namespace TouchTypingGo.Domain.Course.Commands.Course
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
