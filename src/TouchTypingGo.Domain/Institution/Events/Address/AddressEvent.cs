using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Institution.Events.Address
{
    public class AddressEvent : Event
    {
        public string County { get; protected set; }
        public string City { get; protected set; }
        public string Street { get; protected set; }
        public string Number { get; protected set; }
        public string ZipCode { get; protected set; }
    }
}
