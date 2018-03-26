using System;

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
