using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Commands;

namespace TouchTypingGo.Domain.Institution.Commands.Address
{
    public class AddressCommand : Command
    {
        public string County { get; protected set; }
        public string City { get; protected set; }
        public string Street { get; protected set; }
        public string Number { get; protected set; }
        public string ZipCode { get; protected set; }
    }
}
