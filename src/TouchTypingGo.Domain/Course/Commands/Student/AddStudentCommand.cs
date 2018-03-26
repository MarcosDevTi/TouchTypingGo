using System;

namespace TouchTypingGo.Domain.Course.Commands.Student
{
    public class AddStudentCommand : StudentCommandBase
    {
        public AddStudentCommand(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
