using System;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }

        public Command()
        {
            TimeStamp = DateTime.Now;
        }

    }
}
