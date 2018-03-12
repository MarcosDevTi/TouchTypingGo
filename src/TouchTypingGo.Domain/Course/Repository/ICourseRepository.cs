

using System;
using System.Collections;
using System.Collections.Generic;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Domain.Course.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetByTeacher(Guid teacherId);
        
    }
}
