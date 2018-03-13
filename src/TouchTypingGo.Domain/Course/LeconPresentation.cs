using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class LeconPresentation : Entity<LeconPresentation>
    {
        public string Text { get; private set; }
        public string Category { get; private set; }
        public int SpeedReference { get; private set; }
        public int TimeReference { get; private set; }
        public int PrecisionReference { get; private set; }
        public int FontSize { get; private set; }
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
