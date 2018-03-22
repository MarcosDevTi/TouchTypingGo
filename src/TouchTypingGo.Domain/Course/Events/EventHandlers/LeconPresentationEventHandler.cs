using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Course.Events.LessonPresentation;

namespace TouchTypingGo.Domain.Course.Events.EventHandlers
{
    public class lessonPresentationEventHandler:
        IHandler<LessonPresentationAddEvent>,
        IHandler<LessonPresentationDeleteEvent>
    {  
        public void Handle(LessonPresentationAddEvent message)
        {
            // Enviar um e-mail
        }

        public void Handle(LessonPresentationDeleteEvent message)
        {
            // Enviar um e-mail
        }
    }
}
