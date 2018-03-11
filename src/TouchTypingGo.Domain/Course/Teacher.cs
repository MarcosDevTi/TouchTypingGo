using System;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class Teacher : Entity<Teacher>
    {
        public Teacher(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public Course Course { get; set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
