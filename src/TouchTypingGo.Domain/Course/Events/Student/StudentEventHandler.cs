using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Course.Events.Student
{
    public class StudentEventHandler : 
        IHandler<AddStudentEvent>,
        IHandler<DeleteStudentEvent>
    {
        public void Handle(AddStudentEvent message)
        {
            //Send Email
        }

        public void Handle(DeleteStudentEvent message)
        {
            //Send Email
        }
    }
}
