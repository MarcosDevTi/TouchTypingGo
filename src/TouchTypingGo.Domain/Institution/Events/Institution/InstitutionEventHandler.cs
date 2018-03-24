using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Institution.Events.Institution
{
    public class InstitutionEventHandler :
         IHandler<AddInstitutionEvent>
    {
        public void Handle(AddInstitutionEvent message)
        {
            //Send Email
        }
    }
}
