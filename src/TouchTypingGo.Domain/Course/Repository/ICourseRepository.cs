using System;
using System.Collections.Generic;

namespace TouchTypingGo.Domain.Course.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetByTeacher(Guid teacherId);
        IEnumerable<Course> GetCoursesWithLessons();
    }
}
