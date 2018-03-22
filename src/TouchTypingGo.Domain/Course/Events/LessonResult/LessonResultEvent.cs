using System;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.LessonResult
{
    public class LessonResultEvent : Event
    {
        public Guid Id { get; protected set; }
        public int Try { get; protected set; }
        public int Wpm { get; protected set; }
        public int Time { get; protected set; }
        public int Errors { get; protected set; }
        public bool EhAuthenticated { get; protected set; }
        public string ErrorKey { get; protected set; }
        public int CourseId { get; protected set; }
        public bool Active { get; protected set; }
        public Guid lessonPresentationId { get; protected set; }
    }
}
