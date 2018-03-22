namespace TouchTypingGo.Domain.Course.Events.LessonPresentation
{
    public class LessonPresentationAddEvent : LessonPresentationEvent
    {
        public LessonPresentationAddEvent(string text, string category, int speedReference, int timeReference, int precisionReference, int fontSize)
        {
            Text = text;
            Category = category;
            SpeedReference = speedReference;
            TimeReference = timeReference;
            PrecisionReference = precisionReference;
            FontSize = fontSize;
        }
    }
}
