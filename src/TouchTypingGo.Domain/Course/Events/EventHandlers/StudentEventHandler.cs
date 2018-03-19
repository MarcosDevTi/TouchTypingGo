using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Course.Events.Student;

namespace TouchTypingGo.Domain.Course.Events.EventHandlers
{
    public class StudentEventHandler : 
        IHandler<AddStudentEvent>,
        IHandler<DeleteStudentEvent>
    {
        public void Handle(AddStudentEvent message)
        {
            //Send Email
        }

        public void Handle(DeleteStudentEvent message)
        {
            //Send Email
        }
    }
}
