using System;
using TouchTypingGo.Domain.Core.Commands;

namespace TouchTypingGo.Domain.Course.Commands.LeconPresentation
{
    public class LeconPresentationCommand : Command
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
