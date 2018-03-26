using System;

namespace TouchTypingGo.Domain.Course.Commands.Student
{
    public class DeleteStudentCommand : StudentCommandBase
    {
        public DeleteStudentCommand(Guid id)
        {
            Id = id;
        }
    }
}
