using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Commands;

namespace TouchTypingGo.Domain.Course.Commands.LeconResult
{
    public class LeconResultCommandBase : Command
    {
        public Guid Id { get; protected set; }
        public int Try { get; protected set; }
        public int Wpm { get; protected set; }
        public int Time { get; protected set; }
        public int Errors { get; protected set; }
        public bool EhAuthenticated { get; protected set; }
        public string ErrorKey { get; protected set; }
        public int CourseId { get; protected set; }
        public bool Active { get; protected set; }
        public Guid LeconPresentationId { get; protected set; }
    }
}
