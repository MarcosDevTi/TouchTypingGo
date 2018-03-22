using System;
using TouchTypingGo.Domain.Core.Commands;

namespace TouchTypingGo.Domain.Course.Commands.LessonPresentation
{
    public class LessonPresentationCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Text { get; protected set; }
        public string Category { get; protected set; }
        public int SpeedReference { get; protected set; }
        public int TimeReference { get; protected set; }
        public int PrecisionReference { get; protected set; }
        public int FontSize { get; protected set; }
        public Guid UserId { get; protected set; }
    }
}
