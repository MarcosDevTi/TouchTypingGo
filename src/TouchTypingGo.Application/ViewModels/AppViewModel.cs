using System;

namespace TouchTypingGo.Application.ViewModels
{
    public class AppViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Started { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
        public int? MinTime { get; set; }
        public int? MinErrors { get; set; }
    }
}
