using System;

namespace TouchTypingGo.Domain.Course.Commands.Course
{
    public class CourseAddCommand : CourseCommand
    {
        public CourseAddCommand(
            string name, 
            DateTime? limitDate,
            string code)
        {
            Name = name;
            LimitDate = limitDate;
            Code = code;
        }
    }
}
