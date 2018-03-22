using System;

namespace TouchTypingGo.Domain.Course.Events.LessonPresentation
{
    public class LessonPresentationDeleteEvent : LessonPresentationEvent
    {
        public LessonPresentationDeleteEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
