using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class LeconResultRepository : Repository<LeconResult>, ILeconResultRepository
    {
        public LeconResultRepository(TouchTypingGoContext db) : base(db)
        {
        }
    }
}
