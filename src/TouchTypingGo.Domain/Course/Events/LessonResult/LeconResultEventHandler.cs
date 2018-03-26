using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.LessonResult
{
    public class LessonResultEventHandler :
        IHandler<LessonResultAddEvent>,
        IHandler<LessonResultDeleteEvent>
    {
        public void Handle(LessonResultAddEvent message)
        {
            //Send Email
        }

        public void Handle(LessonResultDeleteEvent message)
        {
            //Send Email
        }
    }
}
