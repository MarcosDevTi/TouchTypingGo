using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class LeconPresentation : Entity<LeconPresentation>
    {
        public string Text { get; set; }
        public string Category { get; set; }
        public int SpeedReference { get; set; }
        public int TimeReference { get; set; }
        public int PrecisionReference { get; set; }
        public int FontSize { get; set; }
        [NotMapped]
        public virtual ICollection<Course> Courses { get; private set; }
        [NotMapped]
        public virtual ICollection<LeconResult> LeconResults { get; private set; }
        public override bool IsValid()
        {
            return true;
        }
    }
}
