using System;

namespace TouchTypingGo.Domain.Course.Events.LessonResult
{
    public class LessonResultDeleteEvent : LessonResultEvent
    {
        public LessonResultDeleteEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
