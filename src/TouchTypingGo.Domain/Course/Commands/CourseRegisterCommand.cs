using System;

namespace TouchTypingGo.Domain.Course.Commands
{
    public class CourseRegisterCommand : CourseCommand
    {
        public CourseRegisterCommand(
            string code, 
            string name, 
            DateTime limitDate,
            Guid teacherId)
        {
            Code = code;
            Name = name;
            LimitDate = limitDate;
            TeacherId = teacherId;
        }
    }
}
