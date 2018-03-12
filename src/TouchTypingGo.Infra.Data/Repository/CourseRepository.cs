using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(TouchTypingGoContext context) : base(context)
        {
            
        }
        public IEnumerable<Course> GetByTeacher(Guid teacherId)
        {
            return Db.Courses.Where(c => c.TeacherId == teacherId);
        }
    }
}
