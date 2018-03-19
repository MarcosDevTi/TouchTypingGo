using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Commands;

namespace TouchTypingGo.Domain.Course.Commands.Student
{
    public class StudentCommandBase : Command
    {
        public Guid Id { get; protected set; }
        public string Name { get;protected set; }
        public string Email { get;protected set; }
    }
}
