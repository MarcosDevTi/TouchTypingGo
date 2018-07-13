using System;
using TouchTypingGo.Application.Cqrs.Query.Models;
using TouchTypingGo.Domain.Core.Cqrs.Query;

namespace TouchTypingGo.Application.Cqrs.Query.Queries
{
    public class GetLessonPresentationApp : IQuery<LessonPresentationApp>
    {
        public GetLessonPresentationApp(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
