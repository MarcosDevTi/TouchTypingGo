using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.Keyboard
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
