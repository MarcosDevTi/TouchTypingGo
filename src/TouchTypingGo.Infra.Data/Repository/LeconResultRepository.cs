using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class lessonResultRepository : Repository<LessonResult>, ILessonResultRepository
    {
        public lessonResultRepository(TouchTypingGoContext db, IUser user) : base(db, user)
        {
        }
    }
}
