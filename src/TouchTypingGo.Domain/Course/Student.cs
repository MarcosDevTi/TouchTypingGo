using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class Student : Entity<Student>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public virtual ICollection<Course> Course { get; private set; }
        [NotMapped]
        public virtual ICollection<LeconResult> LeconResults { get; private set; }

        public override bool IsValid()
        {
            return true;
        }
    }
}
