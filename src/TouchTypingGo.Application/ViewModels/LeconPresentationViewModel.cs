using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TouchTypingGo.Application.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    public class LeconPresentationViewModel : IMapTo<LeconPresentation>, IMapFrom<LeconPresentation>
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O código é obrigatório")]
        [Display(Name = "Texto do Exercício")]
        public string Text { get; set; }
        [Required(ErrorMessage = "O código é obrigatório")]
        [MinLength(2, ErrorMessage = "O tamanho mínimo é {1}")]
        [MaxLength(20, ErrorMessage = "O tamanho máximo é {1}")]
        [Display(Name = "Categoria")]
        public string Category { get; set; }
        public int SpeedReference { get; set; }
        public int TimeReference { get; set; }
        public int PrecisionReference { get; set; }
        [Display(Name = "Tabanho da fonte")]
        public int FontSize { get; set; }
        public virtual ICollection<CourseViewModel> Courses { get; private set; }
        public virtual ICollection<LeconResultViewModel> LeconResults { get; private set; }
    }
}
