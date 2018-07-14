using System.Collections.Generic;
using System.Linq;
using TouchTypingGo.Application.Cqrs.Query.Models.Course;
using TouchTypingGo.Application.Cqrs.Query.Queries;
using TouchTypingGo.Application.Cqrs.Query.Queries.Course;
using TouchTypingGo.Domain.Core.Cqrs.Query;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Handlers.Queries
{
    public class CourseQueryHandler :
        IQueryHandler<GetCoursesIndex, IReadOnlyList<CourseIndex>>,
        IQueryHandler<GetCourseEditDetails, CourseEditDetails>,
        IQueryHandler<GetCourseDeleteDetails, CourseDeleteDetails>
    {
        private readonly TouchTypingGoContext _context;

        public CourseQueryHandler(TouchTypingGoContext context)
        {
            _context = context;
        }

        public IReadOnlyList<CourseIndex> Handle(GetCoursesIndex query)
        {
            return _context.Courses.Select(x => new CourseIndex
            {
                Id = x.Id,
                Name = x.Name,
                Code = x.Code,
                LimitDate = x.LimitDate,
                Lessons = x.CourseLessonPresentations.Select(l => l.LessonPresentation).Select(c => new LessonsCourseIndex
                {
                    Id = c.Id,
                    Name = c.Name,
                    Text = c.Text
                })
            }).ToList();
        }

        public CourseEditDetails Handle(GetCourseEditDetails query)
        {
            var course = _context.Courses.Find(query.Id);
            return new CourseEditDetails { Id = course.Id, Name = course.Name, LimitDate = course.LimitDate };
        }

        public CourseDeleteDetails Handle(GetCourseDeleteDetails query)
        {
            var course = _context.Courses.Find(query.Id);
            return new CourseDeleteDetails { Id = course.Id, Name = course.Name, LimitDate = course.LimitDate };
        }
    }
}
