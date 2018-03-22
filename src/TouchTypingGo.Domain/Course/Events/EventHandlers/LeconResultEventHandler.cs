using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Course.Events.LessonResult;

namespace TouchTypingGo.Domain.Course.Events.EventHandlers
{
    public class lessonResultEventHandler:
        IHandler<LessonResultAddEvent>,
        IHandler<LessonResultDeleteEvent>
    {
        public void Handle(LessonResultAddEvent message)
        {
            //Send Email
        }

        public void Handle(LessonResultDeleteEvent message)
        {
            //Send Email
        }
    }
}
