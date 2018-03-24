using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Institution.Events.Institution
{
    public class InstitutionEvent : Event
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Phone { get; protected set; }
        public Guid? AddressId { get; protected set; }
    }
}
