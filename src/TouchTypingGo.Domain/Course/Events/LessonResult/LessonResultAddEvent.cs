using System;

namespace TouchTypingGo.Domain.Course.Events.LessonResult
{
    public class LessonResultAddEvent : LessonResultEvent
    {
        public LessonResultAddEvent(int @try, int wpm, int time, int errors, bool ehAuthenticated, string errorKey, int courseId, bool active, Guid lessonPresentationId)
        {
            Try = @try;
            Wpm = wpm;
            Time = time;
            Errors = errors;
            EhAuthenticated = ehAuthenticated;
            ErrorKey = errorKey;
            CourseId = courseId;
            Active = active;
            lessonPresentationId = lessonPresentationId;
        }
    }
}
