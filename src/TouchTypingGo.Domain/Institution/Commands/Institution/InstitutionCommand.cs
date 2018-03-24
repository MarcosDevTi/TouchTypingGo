using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Commands;

namespace TouchTypingGo.Domain.Institution.Commands.Institution
{
    public class InstitutionCommand : Command
    {
       
        public string Name { get; protected set; }
        public string Email { get; protected set; }
        public string Phone { get; protected set; }
        public Guid? AddressId { get; protected set; }
    }
}
