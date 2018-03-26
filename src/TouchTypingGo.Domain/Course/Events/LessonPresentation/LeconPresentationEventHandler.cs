using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.LessonPresentation
{
    public class LessonPresentationEventHandler :
        IHandler<LessonPresentationAddEvent>,
        IHandler<LessonPresentationDeleteEvent>
    {
        public void Handle(LessonPresentationAddEvent message)
        {
            // Enviar um e-mail
        }

        public void Handle(LessonPresentationDeleteEvent message)
        {
            // Enviar um e-mail
        }
    }
}
