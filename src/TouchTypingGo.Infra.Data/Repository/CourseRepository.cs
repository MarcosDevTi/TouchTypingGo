using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Dapper;
using Microsoft.EntityFrameworkCore;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Repository;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly TouchTypingGoContext _context;
        public CourseRepository(TouchTypingGoContext context, IUser user) : base(context, user)
        {
            _context = context;
        }

        public override Course GetById(Guid? id)
        {
            var teste = _context.Courses
                .Include(c => c.CourseLessonPresentations)
                .ThenInclude(x => x.LessonPresentation).FirstOrDefault(x=>x.Id == id);

            return _context.Courses
                .Include(c => c.CourseLessonPresentations)
                .ThenInclude(x=>x.LessonPresentation)
                .FirstOrDefault(c => c.Id == id);
        }


        public override IEnumerable<Course> GetAll()
        {
            var teste = _context.Courses
                .Include(c => c.CourseLessonPresentations)
                .ThenInclude(x => x.LessonPresentation);

            return teste;
            //    .FirstOrDefault()?.CourseLessonPresentations
            //    .GroupBy(x=>x.Course,
            //    x=>x, (key, value) => new {Course  = key, lp = value.Select(x=>x.LessonPresentation).ToList()});

            //return _context.Courses
            //    .Include(c => c.CourseLessonPresentations)
            //    .ThenInclude(x => x.LessonPresentation);
        }

        public IEnumerable<Course> GetCoursesWithLessons()
        {
            return _context.Courses
                .Include(c => c.CourseLessonPresentations)
                .ThenInclude(x => x.LessonPresentation);

            //_context.Courses
            //    .Include(c => c.CourseLessonPresentations)
            //    .ThenInclude(x => x.LessonPresentation)
            //    .FirstOrDefault()?.CourseLessonPresentations
            //    .GroupBy(clp => clp.Course,
            //        clp => clp, (key, value) => new { Course = key, lp = value.Select(clp => clp.LessonPresentation).ToList()}).ToDictionary(x=>x.Course, x=>x.lp);
        }
        //public override void Add(Course course)
        //{
        //    //var teacher = _context.Teachers.FirstOrDefault(x => x.Id == course.TeacherId);
        //    //course.SetTeacher(teacher);
        //    _context.Add(course);
        //}

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
