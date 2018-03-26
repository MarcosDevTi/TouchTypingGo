using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class LessonResultRepository : Repository<LessonResult>, ILessonResultRepository
    {
        public LessonResultRepository(TouchTypingGoContext db, IUser user) : base(db, user)
        {
        }
    }
}
