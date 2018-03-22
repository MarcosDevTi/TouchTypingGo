using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(TouchTypingGoContext db, IUser user) : base(db, user)
        {
        }
    }
}
