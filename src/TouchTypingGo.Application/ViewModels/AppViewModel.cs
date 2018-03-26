using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TouchTypingGo.Application.ViewModels
{
    public class AppViewModel
    {
        public Guid Id { get; set; }
        [Required, DisplayName("Name")]
        public string Name { get; set; }
        public bool Started { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
        public int? MinTime { get; set; }
        public int? MinErrors { get; set; }
    }
}
