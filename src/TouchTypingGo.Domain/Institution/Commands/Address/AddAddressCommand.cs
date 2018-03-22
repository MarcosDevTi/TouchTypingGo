using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Institution.Commands.Address
{
    public class AddAddressCommand : AddressCommand
    {
        public AddAddressCommand(string county, string city, string street, string number, string zipCode)
        {
            County = county;
            City = city;
            Street = street;
            Number = number;
            ZipCode = zipCode;
        }
    }
}
