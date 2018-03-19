using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Events.Keyboard
{
    public class DeleteKeyboardEvent : KeyboardEvent
    {
        public DeleteKeyboardEvent(Guid id)
        {
            Id = id;
        }
    }
}
