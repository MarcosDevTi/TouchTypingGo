using System;
using TouchTypingGo.Application.Cqrs.Query.Models.Course;
using TouchTypingGo.Domain.Core.Cqrs.Query;

namespace TouchTypingGo.Application.Cqrs.Query.Queries.Course
{
    public class GetCourseEditDetails : IQuery<CourseEditDetails>
    {
        public GetCourseEditDetails(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
