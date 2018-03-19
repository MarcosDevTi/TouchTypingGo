using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class LeconPresentationRepository : Repository<LeconPresentation>, ILeconPresentationRepository
    {
        public LeconPresentationRepository(TouchTypingGoContext db) : base(db)
        {
        }
    }
}
