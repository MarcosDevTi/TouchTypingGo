using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Commands.Keyboard
{
    public class AddKeyboardCommand : KeyboardCommand
    {
        public AddKeyboardCommand(string name, int lcid, string valHtml, string keyboardContent, bool active)
        {
            Name = name;
            Lcid = lcid;
            ValHtml = valHtml;
            KeyboardContent = keyboardContent;
            Active = active;
        }
    }
}
