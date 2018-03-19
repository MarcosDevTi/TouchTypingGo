using System;
using System.Collections.Generic;
using System.Text;

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
