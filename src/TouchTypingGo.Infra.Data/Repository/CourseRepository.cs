using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Dapper;
using Microsoft.EntityFrameworkCore;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly TouchTypingGoContext _context;
        public CourseRepository(TouchTypingGoContext context) : base(context)
        {
            _context = context;
        }

        public override void Add(Course course)
        {
            //var teacher = _context.Teachers.FirstOrDefault(x => x.Id == course.TeacherId);
            //course.SetTeacher(teacher);
            _context.Add(course);
        }

        //public override IEnumerable<Course> GetAll()
        //{
        //    var sql = @"SELECT * FROM COURSES C " + 
        //        "WHERE C.DELETED = 0 " +
        //        "ORDER BY C.NAME ASC";
        //    return Db.Database.GetDbConnection().Query<Course>(sql);
        //}

        //public override Course GetById(Guid id)
        //{
        //    var sql = @"SELECT * FROM Courses C "+
        //        "LEFT JOIN Teacher TE "+
        //        "ON C.TeacherId = TE.Id "+
        //        "WHERE C.Id = @uid";

        //    var course = Db.Database.GetDbConnection().Query<Course, Teacher, Course>(sql,
        //        (c, te) =>
        //        {
        //            if(te != null)
        //                c.SetTeacher(te);
        //            return c;
        //        }, new {uid = id});

        //    return course.FirstOrDefault();
        //}

        public IEnumerable<Course> GetByTeacher(Guid teacherId)
        {
            return Db.Courses.Where(c => c.TeacherId == teacherId);
        }
    }
}
