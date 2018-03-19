using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Commands.Teacher
{
    public class TeacherAddCommand : TeacherCommand
    {
        public TeacherAddCommand(Guid id, string email, string name)
        {
            Id = id;
            Email = email;
            Name = name;
        }
    }
}
