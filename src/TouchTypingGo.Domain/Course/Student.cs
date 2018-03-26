using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class Student : Entity<Student>
    {
        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        protected Student() { }
        public string Name { get; private set; }
        public string Email { get; private set; }
        [NotMapped]
        public virtual ICollection<Course> Courses { get; private set; }
        [NotMapped]
        public virtual ICollection<LessonResult> lessonResults { get; private set; }

        public static class StudentFactory
        {
            public static Student NewStudentFactory(Guid id, string name, string email)
            {
                return new Student
                {
                    Id = id,
                    Name = name,
                    Email = email
                };
            }

            public static void Go()
            {

            }
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
