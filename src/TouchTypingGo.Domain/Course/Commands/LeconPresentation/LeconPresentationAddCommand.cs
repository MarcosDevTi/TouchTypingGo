using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Course.Commands.LeconPresentation
{
    public class LeconPresentationAddCommand : LeconPresentationCommand
    {
        public LeconPresentationAddCommand(string text, string category, int speedReference, int timeReference, int precisionReference, int fontSize)
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
