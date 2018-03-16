using System;

namespace TouchTypingGo.Domain.Course.Commands.Course
{
    public class CourseAddCommand : CourseCommand
    {
        public CourseAddCommand(
            string code, 
            string name, 
            DateTime? limitDate,
            Guid teacherId)
        {
            Code = code;
            Name = name;
            LimitDate = limitDate;
            TeacherId = teacherId;
        }
    }
}
