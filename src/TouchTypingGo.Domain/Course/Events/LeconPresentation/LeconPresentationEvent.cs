using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.LeconPresentation
{
    public abstract class LeconPresentationEvent : Event
    {
        public Guid Id { get; protected set; }
        public string Text { get; protected set; }
        public string Category { get; protected set; }
        public int SpeedReference { get; protected set; }
        public int TimeReference { get; protected set; }
        public int PrecisionReference { get; protected set; }
        public int FontSize { get; protected set; }
    }
}
