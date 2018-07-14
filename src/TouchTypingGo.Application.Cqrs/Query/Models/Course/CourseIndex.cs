using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TouchTypingGo.Application.Cqrs.Query.Models.Course
{
    public class CourseIndex
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        [DisplayName("End Date"), DataType(DataType.Date)]
        public DateTime? LimitDate { get; set; }
        public IEnumerable<LessonsCourseIndex> Lessons { get; set; }
    }
}
