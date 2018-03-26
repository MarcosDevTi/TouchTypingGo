using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Institution;

namespace TouchTypingGo.Application.ViewModels
{
    [DisplayName("Address")]
    public class AddressViewModel : IMapFrom<Address>, IMapTo<Address>
    {
        public Guid Id { get; set; }
        [Required, DisplayName("County")]
        public string County { get; set; }
        [Required, DisplayName("City")]
        public string City { get; set; }
        [DisplayName("Street")]
        public string Street { get; set; }
        [DisplayName("Number")]
        public string Number { get; set; }
        [DisplayName("ZipCode")]
        public string ZipCode { get; set; }
        public Guid InstitutionId { get; set; }
        public InstitutionViewModel Institution { get; set; }
    }
}
