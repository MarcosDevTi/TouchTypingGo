using System;
using System.Collections.Generic;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class Student : Entity<Student>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Course> Course { get; private set; }
        public ICollection<LeconResult> LeconResults { get; private set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
