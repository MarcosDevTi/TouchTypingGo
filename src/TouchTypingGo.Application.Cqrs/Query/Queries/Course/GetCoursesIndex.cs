using System.Collections.Generic;
using TouchTypingGo.Application.Cqrs.Query.Models.Course;
using TouchTypingGo.Domain.Core.Cqrs.Query;

namespace TouchTypingGo.Application.Cqrs.Query.Queries
{
    public class GetCoursesIndex : IQuery<IReadOnlyList<CourseIndex>>
    {

    }
}
