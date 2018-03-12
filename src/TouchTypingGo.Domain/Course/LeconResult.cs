using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class LeconResult : Entity<LeconResult>
    {
        public int Try { get; private set; }
        public int Wpm { get; private set; }
        public int Time { get; private set; }
        public int Errors { get; private set; }
        //public User User { get; set; }
        public bool EhAuthenticated { get; private set; }
        public string ErrorKey { get; private set; }
        public int CourseId { get; private set; }
        //public EnumLingua LinguaExercicio { get; set; }
        public bool Active { get; private set; }
        public Guid LeconPresentationId { get; private set; }
        public virtual LeconPresentation LeconPresentation { get; private set; }
        [NotMapped]
        public virtual ICollection<Student> Students { get; private set; }
        [NotMapped]
        public virtual ICollection<Course> Courses { get; private set; }

        public override bool IsValid()
        {
            return true;
        }
    }
}
