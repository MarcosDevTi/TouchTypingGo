using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.EventHandlers
{
    public class CourseEventHandler :
        IHandler<CourseRegisterEvent>,
        IHandler<CourseUpdateEvent>,
        IHandler<CourseDeleteEvent>
    {
        public void Handle(CourseRegisterEvent message)
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
