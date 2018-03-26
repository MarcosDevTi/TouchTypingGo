using System;

namespace TouchTypingGo.Domain.Course.Events.Teacher
{
    public class TeacherDeleteEvent : TeacherEvent
    {
        public TeacherDeleteEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
