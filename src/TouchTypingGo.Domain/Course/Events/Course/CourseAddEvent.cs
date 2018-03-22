using System;

namespace TouchTypingGo.Domain.Course.Events.Course
{
    public class CourseAddEvent : CourseEvent
    {
        public CourseAddEvent(
            string name,
            DateTime? limitDate)
        {
            Name = name;
            LimitDate = limitDate;
        }
    }
}
