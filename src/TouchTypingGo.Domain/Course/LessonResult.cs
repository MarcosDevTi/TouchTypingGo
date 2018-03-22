using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class LessonResult : Entity<LessonResult>
    {
        public LessonResult(int @try, int wpm, int time, int errors, bool ehAuthenticated, string errorKey, bool active, Guid lessonPresentationId, Guid userId)
        {
            Id = Guid.NewGuid();
            Try = @try;
            Wpm = wpm;
            Time = time;
            Errors = errors;
            EhAuthenticated = ehAuthenticated;
            ErrorKey = errorKey;
            Active = active;
            LessonPresentationId = lessonPresentationId;
            UserId = userId;
        }

        protected LessonResult() { }

        public int Try { get; private set; }
        public int Wpm { get; private set; }
        public int? Time { get; private set; }
        public int? Errors { get; private set; }
        //public User User { get; set; }
        public bool EhAuthenticated { get; private set; }
        public string ErrorKey { get; private set; }
        //public Guid CourseId { get; private set; }
        //public Course Course { get; private set; }
        //public EnumLingua LinguaExercicio { get; set; }
        public bool Active { get; private set; }
        public Guid LessonPresentationId { get; private set; }
        public virtual LessonPresentation LessonPresentation { get; private set; }
        [NotMapped]
        public virtual ICollection<Student> Students { get; private set; }
        //[NotMapped]
        //public virtual ICollection<Course> Courses { get; private set; }

        public void SetlessonPresentation(LessonPresentation lessonPresentation)
        {
            LessonPresentation = lessonPresentation;
        }
        public override bool IsValid()
        {
            return true;
        }

        public static class LessonResultFactory
        {
            public static LessonResult NewlessonResultFactory(int @try, int wpm, int time, int errors, bool ehAuthenticated, string errorKey, bool active, Guid lessonPresentationId, Guid userId)
            {
                return new LessonResult
                {
                    Try = @try,
                    Wpm = wpm,
                    Time = time,
                    Errors = errors,
                    EhAuthenticated = ehAuthenticated,
                    ErrorKey = errorKey,
                    Active = active,
                    LessonPresentationId = lessonPresentationId,
                    UserId = userId
                };
            }
        }
    }
}
