using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Application.Cqrs.Query.Models.Course
{
    public class AddLesson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public int SpeedReference { get; set; }
        public int TimeReference { get; set; }
        public int PrecisionReference { get; set; }
    }
}
