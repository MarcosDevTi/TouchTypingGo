using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TouchTypingGo.Domain.Core.Cqrs.Command;

namespace TouchTypingGo.Application.Cqrs.Query.Models.Course
{
    public class CourseEditDetails : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [DisplayName("End Date"), DataType(DataType.Date)]
        public DateTime? LimitDate { get; set; }
        public IEnumerable<LessonsCourseIndex> Lessons { get; set; }
    }
}
