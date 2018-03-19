using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Course.Events.Keyboard;
using TouchTypingGo.Domain.Course.Events.Student;

namespace TouchTypingGo.Domain.Course.Events.EventHandlers
{
    public class KeyboardEventHandler:
        IHandler<AddKeyboardEvent>,
        IHandler<DeleteKeyboardEvent>
    {
        public void Handle(AddKeyboardEvent message)
        {
            //Send Email
        }

        public void Handle(DeleteKeyboardEvent message)
        {
            //Send Email
        }
    }
}
