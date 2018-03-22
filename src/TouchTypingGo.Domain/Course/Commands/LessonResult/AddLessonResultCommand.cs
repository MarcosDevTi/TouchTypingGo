using System;

namespace TouchTypingGo.Domain.Course.Commands.LessonResult
{
    public class AddLessonResultCommand : LessonResultCommandBase
    {
        public AddLessonResultCommand(
            int @try, int wpm, int time, int errors, bool ehAuthenticated, string errorKey, bool active, Guid lessonPresentationId, Guid userId)
        {
            Try = @try;
            Wpm = wpm;
            Time = time;
            Errors = errors;
            EhAuthenticated = ehAuthenticated;
            ErrorKey = errorKey;
            Active = active;
            LessonPresentationId = lessonPresentationId;
            UserId = userId;
        }
    }
}
