using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Events
{
    public class CourseDeleteEvent : CourseEvent
    {
        public CourseDeleteEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
