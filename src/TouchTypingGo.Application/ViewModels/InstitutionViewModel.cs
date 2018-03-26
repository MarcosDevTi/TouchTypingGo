using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TouchTypingGo.Application.ViewModels
{
    [DisplayName("Institution")]
    public class InstitutionViewModel
    {
        public Guid Id { get; set; }
        [Required, DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid? AddressId { get; set; }
        public AddressViewModel Address { get; set; }

    }
}
