using System;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Institution
{
    public class Address : Entity<Address>
    {
        protected Address()
        {

        }
        public Address(string county, string city, string street, string number, string zipCode)
        {
            County = county;
            City = city;
            Street = street;
            Number = number;
            ZipCode = zipCode;
        }
        public string County { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string ZipCode { get; private set; }
        public Institution Institution { get; private set; }
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
