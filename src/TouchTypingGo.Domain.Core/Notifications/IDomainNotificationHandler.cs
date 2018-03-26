using System.Collections.Generic;
using TouchTypingGo.Domain.Core.Events;

namespace TouchTypingGo.Domain.Core.Notifications
{
    public interface IDomainNotificationHandler<T> : IHandler<T> where T : Message
    {
        bool HasNotifications();
        List<T> GetNotifications();
    }
}
