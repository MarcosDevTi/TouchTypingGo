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
