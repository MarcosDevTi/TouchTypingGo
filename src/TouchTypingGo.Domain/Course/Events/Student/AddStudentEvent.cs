namespace TouchTypingGo.Domain.Course.Events.Student
{
    public class AddStudentEvent : StudentEventBase
    {
        public AddStudentEvent(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
