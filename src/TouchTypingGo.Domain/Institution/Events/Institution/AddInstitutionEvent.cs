using System;

namespace TouchTypingGo.Domain.Institution.Events.Institution
{
    public class AddInstitutionEvent : InstitutionEvent
    {
        public AddInstitutionEvent(string name, string email, string phone, Guid? addressId)
        {
            Name = name;
            Email = email;
            Phone = phone;
            AddressId = addressId;
        }
    }
}
