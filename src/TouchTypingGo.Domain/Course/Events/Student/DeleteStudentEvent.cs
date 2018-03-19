using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Events.Student
{
    public class DeleteStudentEvent : StudentEventBase
    {
        public DeleteStudentEvent(Guid id)
        {
            Id = id;
        }
    }
}
