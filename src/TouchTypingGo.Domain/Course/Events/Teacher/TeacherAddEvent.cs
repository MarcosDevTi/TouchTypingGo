namespace TouchTypingGo.Domain.Course.Events.Teacher
{
    public class TeacherAddEvent : TeacherEvent
    {
        public TeacherAddEvent(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
