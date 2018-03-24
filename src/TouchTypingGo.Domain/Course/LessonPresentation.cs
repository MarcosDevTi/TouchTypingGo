using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class LessonPresentation : Entity<LessonPresentation>
    {
        public LessonPresentation(string text, string category, int speedReference, int timeReference, int precisionReference, int fontSize)
        {
            Id = Guid.NewGuid();
            Text = text;
            Category = category;
            SpeedReference = speedReference;
            TimeReference = timeReference;
            PrecisionReference = precisionReference;
            FontSize = fontSize;
        }

        protected LessonPresentation() { }

        public string Name { get; private set; }
        public string Text { get; private set; }
        public string Category { get; private set; }
        public int SpeedReference { get; private set; }
        public int TimeReference { get; private set; }
        public int PrecisionReference { get; private set; }
        public int FontSize { get; private set; }
        [NotMapped]
        public virtual ICollection<CourseLessonPresentation> CourseLessonPresentations { get; set; }
        [NotMapped]
        public virtual ICollection<LessonResult> LessonResults { get; private set; }
        public override bool IsValid()
        {
            return true;
        }

        public static class LessonPresentationFactory
        {
            public static LessonPresentation NewlessonPresentationFactory(string name, string text, string category, int speedReference, int timeReference, int precisionReference, int fontSize, Guid? userId)
            {
                return new LessonPresentation
                {
                    Name = name,
                    Text = text,
                    Category = category,
                    SpeedReference = speedReference,
                    TimeReference = timeReference,
                    PrecisionReference = precisionReference,
                    FontSize = fontSize,
                    UserId = userId
                };
            }
        }
    }
}
