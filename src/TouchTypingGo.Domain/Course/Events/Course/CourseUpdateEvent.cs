using System;

namespace TouchTypingGo.Domain.Course.Events.Course
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
