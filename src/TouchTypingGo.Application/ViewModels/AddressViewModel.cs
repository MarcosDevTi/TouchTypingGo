using System;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Institution;

namespace TouchTypingGo.Application.ViewModels
{
    public class AddressViewModel : IMapFrom<Address>, IMapTo<Address>
    {
        public Guid Id { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public Guid InstitutionId { get; set; }
        public InstitutionViewModel Institution { get; set; }
    }
}
