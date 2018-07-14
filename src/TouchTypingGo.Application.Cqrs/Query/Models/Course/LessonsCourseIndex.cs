using System;

namespace TouchTypingGo.Application.Cqrs.Query.Models.Course
{
    public class LessonsCourseIndex
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
    }
}
