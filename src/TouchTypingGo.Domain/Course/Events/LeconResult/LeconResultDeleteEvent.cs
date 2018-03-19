using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Events.LeconResult
{
    public class LeconResultDeleteEvent : LeconResultEvent
    {
        public LeconResultDeleteEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
