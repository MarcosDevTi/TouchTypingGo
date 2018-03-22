using System;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.LessonPresentation
{
    public abstract class LessonPresentationEvent : Event
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
