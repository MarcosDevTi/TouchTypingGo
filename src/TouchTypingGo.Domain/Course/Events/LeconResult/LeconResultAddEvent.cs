using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Events.LeconResult
{
    public class LeconResultAddEvent : LeconResultEvent
    {
        public LeconResultAddEvent(int @try, int wpm, int time, int errors, bool ehAuthenticated, string errorKey, int courseId, bool active, Guid leconPresentationId)
        {
            Try = @try;
            Wpm = wpm;
            Time = time;
            Errors = errors;
            EhAuthenticated = ehAuthenticated;
            ErrorKey = errorKey;
            CourseId = courseId;
            Active = active;
            LeconPresentationId = leconPresentationId;
        }
    }
}
