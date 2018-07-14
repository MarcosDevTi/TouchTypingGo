using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TouchTypingGo.Application.Cqrs.Query.Models.Course
{
    public class CourseDeleteDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [DisplayName("End Date"), DataType(DataType.Date)]
        public DateTime? LimitDate { get; set; }
    }
}
