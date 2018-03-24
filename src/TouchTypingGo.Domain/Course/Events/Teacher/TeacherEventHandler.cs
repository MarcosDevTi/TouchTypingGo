using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.Teacher
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
