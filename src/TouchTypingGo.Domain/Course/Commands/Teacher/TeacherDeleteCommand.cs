using System;

namespace TouchTypingGo.Domain.Course.Commands.Teacher
{
    public class TeacherDeleteCommand : TeacherCommand
    {
        public TeacherDeleteCommand(Guid id)
        {
            Id = id;
        }
    }
}
