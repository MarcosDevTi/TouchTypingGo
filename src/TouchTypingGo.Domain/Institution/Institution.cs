using System;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Institution
{
    public class Institution : Entity<Institution>
    {
        protected Institution()
        {
            
        }
        public Institution(string name, string email, string phone,Address address)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
        }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Guid? AddressId { get; private set; }
        public Address Address { get; private set; }

        public void SetAddress(Address address)
        {
            Address = address;
        }
        public override bool IsValid()
        {
            return true;
        }
    }
}
