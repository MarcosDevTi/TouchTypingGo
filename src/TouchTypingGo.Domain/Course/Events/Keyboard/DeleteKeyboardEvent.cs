using System;

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
