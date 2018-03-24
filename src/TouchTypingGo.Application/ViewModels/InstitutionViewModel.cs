using System;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Institution;

namespace TouchTypingGo.Application.ViewModels
{
    public class InstitutionViewModel : IMapFrom<Institution>, IMapTo<Institution>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid? AddressId { get; set; }
        public AddressViewModel Address { get; set; }

    }
}
