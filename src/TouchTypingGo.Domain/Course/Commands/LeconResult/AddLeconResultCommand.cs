using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Commands.LeconResult
{
    public class AddLeconResultCommand : LeconResultCommandBase
    {
        public AddLeconResultCommand(int @try, int wpm, int time, int errors, bool ehAuthenticated, string errorKey, bool active, Guid leconPresentationId)
        {
            Try = @try;
            Wpm = wpm;
            Time = time;
            Errors = errors;
            EhAuthenticated = ehAuthenticated;
            ErrorKey = errorKey;
            Active = active;
            LeconPresentationId = leconPresentationId;
        }
    }
}
