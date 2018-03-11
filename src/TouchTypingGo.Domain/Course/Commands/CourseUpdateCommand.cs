using System;

namespace TouchTypingGo.Domain.Course.Commands
{
    public class CourseUpdateCommand : CourseCommand
    {
        public CourseUpdateCommand(
            string name,
            DateTime limitDate)
        {
            Name = name;
            LimitDate = limitDate;
        }
    }
}
