using System;
using System.Collections.Generic;
using System.Text;

namespace TouchTypingGo.Domain.Institution.Commands.Institution
{
    public class AddInstitutionCommand : InstitutionCommand
    {
        public AddInstitutionCommand(string name, string email, string phone, Guid? addressId)
        {
            Name = name;
            Email = email;
            Phone = phone;
            AddressId = addressId;
        }
    }
}
