using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class User : Entity<User>
    {
        public string Name { get; protected set; }
        public string Email { get; protected set; }

        public override bool IsValid()
        {

            return true;
        }
    }
}
