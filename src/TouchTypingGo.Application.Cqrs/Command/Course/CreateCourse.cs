using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TouchTypingGo.Domain.Core.Cqrs.Command;

namespace TouchTypingGo.Application.Cqrs.Command.Course
{
    [DisplayName("Course")]
    public class CreateCourse : ICommand
    {
        public string Name { get; set; }
        [DisplayName("Limit Date"), DataType(DataType.Date)]
        public DateTime? LimitDate { get; set; }
    }
}
