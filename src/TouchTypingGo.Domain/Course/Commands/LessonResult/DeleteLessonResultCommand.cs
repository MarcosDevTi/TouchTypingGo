using System;

namespace TouchTypingGo.Domain.Course.Commands.LessonResult
{
    public class DeleteLessonResultCommand : LessonResultCommandBase
    {
        public DeleteLessonResultCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
