using System;

namespace TouchTypingGo.Domain.Course.Commands.LessonPresentation
{
    public class LessonPresentationAddCommand : LessonPresentationCommand
    {
        public LessonPresentationAddCommand(string name, string text, string category, int speedReference, int timeReference, int precisionReference, int fontSize, Guid userId)
        {
            Name = name;
            Text = text;
            Category = category;
            SpeedReference = speedReference;
            TimeReference = timeReference;
            PrecisionReference = precisionReference;
            FontSize = fontSize;
            UserId = userId;
        }
    }
}
