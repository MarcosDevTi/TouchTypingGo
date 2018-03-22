using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course
{
    public class CourseLessonPresentation
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid LessonPresentationId { get; set; }
        public LessonPresentation LessonPresentation { get; set; }
    }
}
