using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Events
{
    public class CourseUpdateEvent : CourseEvent
    {
        public CourseUpdateEvent(
            string code,
            string name,
            DateTime? limitDate)
        {
            Code = code;
            Name = name;
            LimitDate = limitDate;
        }
    }
}
