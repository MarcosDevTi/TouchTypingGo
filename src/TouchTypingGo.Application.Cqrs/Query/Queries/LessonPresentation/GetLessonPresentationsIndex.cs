using System.Collections.Generic;
using TouchTypingGo.Application.Cqrs.Query.Models.LessonPresentation;
using TouchTypingGo.Domain.Core.Cqrs.Query;

namespace TouchTypingGo.Application.Cqrs.Query.Queries.LessonPresentation
{
    public class GetLessonPresentationsIndex : IQuery<IReadOnlyList<LessonPresentationIndex>>
    {
        //TODO: Parameters search and order by
    }
}
