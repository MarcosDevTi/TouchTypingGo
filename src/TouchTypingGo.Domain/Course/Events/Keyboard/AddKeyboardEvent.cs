using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Events.Keyboard
{
    public class AddKeyboardEvent : KeyboardEvent
    {
        public AddKeyboardEvent(string name, int lcid, string valHtml, string keyboardContent, bool active)
        {
            Name = name;
            Lcid = lcid;
            ValHtml = valHtml;
            KeyboardContent = keyboardContent;
            Active = active;
        }
    }
}
