using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Course.Events.LeconResult;

namespace TouchTypingGo.Domain.Course.Events.EventHandlers
{
    public class LeconResultEventHandler:
        IHandler<LeconResultAddEvent>,
        IHandler<LeconResultDeleteEvent>
    {
        public void Handle(LeconResultAddEvent message)
        {
            //Send Email
        }

        public void Handle(LeconResultDeleteEvent message)
        {
            //Send Email
        }
    }
}
