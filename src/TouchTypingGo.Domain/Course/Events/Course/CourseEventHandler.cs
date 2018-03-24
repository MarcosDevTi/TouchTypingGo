using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.Course
{
    public class CourseEventHandler :
        IHandler<CourseAddEvent>,
        IHandler<CourseUpdateEvent>,
        IHandler<CourseDeleteEvent>
    {
        public void Handle(CourseAddEvent message)
        {
            // Enviar um e-mail
        }

        public void Handle(CourseUpdateEvent message)
        {
            // Enviar um e-mail
        }

        public void Handle(CourseDeleteEvent message)
        {
            // Enviar um e-mail
        }
    }
}
