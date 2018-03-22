using System;

namespace TouchTypingGo.Domain.Course.Commands.LessonPresentation
{
    public class LessonPresentationDeleteCommand : LessonPresentationCommand
    {
        public LessonPresentationDeleteCommand(Guid id)
        {
            Id = id;
            AggregateId = Id;
        }
    }
}
