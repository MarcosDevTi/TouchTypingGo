using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Application.ViewModels
{
    public class PreviewLessonViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PreviewText { get; set; }
        public int? Wpm { get; set; }
        public int? Time { get; set; }
        public int? Errors { get; set; }
        public bool Started { get; set; }
        public int? CoutResolute { get; set; }
        public string Category { get; set; }
    }
}
