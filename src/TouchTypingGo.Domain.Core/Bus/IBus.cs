using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Commands;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Core.Bus
{
    public interface IBus
    {
        void SendCommand<T>(T theCommand) where T : Command;
        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}
