using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using TouchTypingGo.Application.ViewModels;

namespace TouchTypingGo.Application.Interfaces
{
    public interface ICourseAppService : IDisposable
    {
        //void Add(CourseViewModel courseViewModel);
        string Add(CourseViewModel courseViewModel);
        IEnumerable<CourseViewModel> GetAll();
        IEnumerable<CourseViewModel> GetCourseByTeacher(Guid teacherId);
        CourseViewModel GetById(Guid id);
        void Update(CourseViewModel courseViewModel);
        void Delete(Guid id);
        IEnumerable<TeacherViewModel> GetAllTeachers();
        SelectList Teachers();
        IEnumerable<CourseViewModel> GetCoursesWithLessons();
    }
}
