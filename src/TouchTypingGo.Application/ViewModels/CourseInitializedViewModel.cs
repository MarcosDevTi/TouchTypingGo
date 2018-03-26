using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TouchTypingGo.Application.ViewModels
{
    public class CourseInitializedViewModel
    {
        public CourseInitializedViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required, MinLength(2), MaxLength(150), DisplayName("Name")]
        public string Name { get; set; }
    }
}
