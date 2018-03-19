using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Events.LeconPresentation
{
    public class LeconPresentationAddEvent : LeconPresentationEvent
    {
        public LeconPresentationAddEvent(string text, string category, int speedReference, int timeReference, int precisionReference, int fontSize)
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
