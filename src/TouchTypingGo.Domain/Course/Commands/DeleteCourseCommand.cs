using System;

namespace TouchTypingGo.Domain.Course.Commands
{
    public class DeleteCourseCommand : CourseCommand
    {
        public DeleteCourseCommand(Guid id)
        {
            Id = id;
            AggregateId = Id;
        }
    }
}
