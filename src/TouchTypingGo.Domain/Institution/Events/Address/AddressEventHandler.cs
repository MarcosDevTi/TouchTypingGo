﻿using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Institution.Events.Address
{
    public class AddressEventHandler :
        IHandler<AddAddressEvent>
    {
        public void Handle(AddAddressEvent message)
        {
            //Send Email
        }
    }
}
