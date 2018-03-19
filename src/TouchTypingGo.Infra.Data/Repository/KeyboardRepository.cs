using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class KeyboardRepository : Repository<Keyboard>, IKeyboardRepository
    {
        public KeyboardRepository(TouchTypingGoContext db) : base(db)
        {
        }
    }
}
