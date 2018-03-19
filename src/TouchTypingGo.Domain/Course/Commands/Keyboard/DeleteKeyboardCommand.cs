using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Commands.Keyboard
{
    public class DeleteKeyboardCommand : KeyboardCommand
    {
        public DeleteKeyboardCommand(Guid id)
        {
            Id = id;
        }
    }
}
