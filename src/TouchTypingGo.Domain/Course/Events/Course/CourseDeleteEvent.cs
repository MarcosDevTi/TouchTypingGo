using System;

namespace TouchTypingGo.Domain.Course.Events.Course
{
    public class CourseDeleteEvent : CourseEvent
    {
        public CourseDeleteEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
