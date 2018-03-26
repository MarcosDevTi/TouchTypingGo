using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Institution;

namespace TouchTypingGo.Application.ViewModels
{
    [DisplayName("Institution")]
    public class InstitutionViewModel : IMapFrom<Institution>, IMapTo<Institution>
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
