using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(TouchTypingGoContext db, IUser user) : base(db, user)
        {
        }

        //public override Teacher GetById(Guid id)
        //{
        //    var sql = @"SELECT * FROM TEACHER " +
        //              "WHERE Id = @oid";
        //    return Db.Database.GetDbConnection().Query<Teacher>(sql, new {oid = id}).FirstOrDefault();
        //}
    }
}
