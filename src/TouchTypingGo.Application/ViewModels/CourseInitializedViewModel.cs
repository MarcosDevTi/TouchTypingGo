using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo é {1}")]
        [MaxLength(150, ErrorMessage = "O tamanho máximo é {1}")]
        [Display(Name = "Nome do Curso")]
        public string Name { get; set; }
    }
}
