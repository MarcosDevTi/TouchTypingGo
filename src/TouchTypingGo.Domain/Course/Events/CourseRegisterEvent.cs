using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events
{
    public class CourseRegisterEvent : CourseEvent
    {
        public CourseRegisterEvent(
            string name,
            DateTime? limitDate)
        {
            Name = name;
            LimitDate = limitDate;
        }
    }
}
