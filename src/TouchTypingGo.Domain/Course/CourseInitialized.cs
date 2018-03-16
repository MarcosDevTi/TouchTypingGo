using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class CourseInitialized : Entity<CourseInitialized>
    {
        public string Name { get; set; }

        public void CreateCourseCostumized(Guid idCourseInitialized, Guid idTeacher)
        {
            //TODO: Implementar método de criação inicial de curso
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
