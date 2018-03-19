using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;
using TouchTypingGo.Domain.Course.Events.Teacher;

namespace TouchTypingGo.Domain.Course.Events.EventHandlers
{
    public class TeacherEventHandler:
        IHandler<TeacherAddEvent>,
        IHandler<TeacherDeleteEvent>
    {
        public void Handle(TeacherAddEvent message)
        {
            //Send Email
        }

        public void Handle(TeacherDeleteEvent message)
        {
            // Send Email
        }
    }
}
