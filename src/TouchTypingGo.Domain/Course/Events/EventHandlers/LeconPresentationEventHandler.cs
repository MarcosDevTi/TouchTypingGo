using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Course.Commands.LeconPresentation;
using TouchTypingGo.Domain.Course.Events.LeconPresentation;

namespace TouchTypingGo.Domain.Course.Events.EventHandlers
{
    public class LeconPresentationEventHandler:
        IHandler<LeconPresentationAddEvent>,
        IHandler<LeconPresentationDeleteEvent>
    {  
        public void Handle(LeconPresentationAddEvent message)
        {
            // Enviar um e-mail
        }

        public void Handle(LeconPresentationDeleteEvent message)
        {
            // Enviar um e-mail
        }
    }
}
