using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events
{
    public abstract class CourseEvent : Event
    {
        public Guid Id { get; protected set; }
        public string Code { get; protected set; }
        public string Name { get; protected set; }
        public DateTime LimitDate { get; protected set; }
    }
}
