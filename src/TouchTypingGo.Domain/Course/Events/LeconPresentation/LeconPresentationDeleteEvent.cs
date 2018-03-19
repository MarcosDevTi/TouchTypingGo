using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Events.LeconPresentation
{
    public class LeconPresentationDeleteEvent : LeconPresentationEvent
    {
        public LeconPresentationDeleteEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
