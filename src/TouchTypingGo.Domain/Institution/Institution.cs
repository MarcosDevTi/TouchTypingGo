using System;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Institution
{
    public class Institution : Entity<Institution>
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Guid AddressId { get; private set; }
        public Address Address { get; private set; }
        public override bool IsValid()
        {
            return true;
        }
    }
}
