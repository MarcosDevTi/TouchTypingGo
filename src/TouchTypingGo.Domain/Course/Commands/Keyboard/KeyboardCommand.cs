using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Commands;

namespace TouchTypingGo.Domain.Course.Commands.Keyboard
{
    public class KeyboardCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public int Lcid { get; protected set; }
        public string ValHtml { get; protected set; }
        public string KeyboardContent { get; protected set; }
        public bool Active { get; protected set; }
    }
}
