using System;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.Keyboard
{
    public class KeyboardEvent : Event
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public int Lcid { get; protected set; }
        public string ValHtml { get; protected set; }
        public string KeyboardContent { get; protected set; }
        public bool Active { get; protected set; }
    }
}
