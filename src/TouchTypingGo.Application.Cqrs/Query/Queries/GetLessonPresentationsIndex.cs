using System.Collections.Generic;
using TouchTypingGo.Application.Cqrs.Query.Models;
using TouchTypingGo.Domain.Core.Cqrs.Query;

namespace TouchTypingGo.Application.Cqrs.Query.Queries
{
    public class GetLessonPresentationsIndex : IQuery<IReadOnlyList<LessonPresentationIndex>>
    {
        //TODO: Parameters search and order by
    }
}
