using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TouchTypingGo.Domain.Core.Notifications
{
    public class DomainNotificationHandler : IDomainNotificationHandler<DomainDotification>
    {
        private List<DomainDotification> _notifications;

        public DomainNotificationHandler()
        {
            _notifications = new List<DomainDotification>();
        }
        public void Handle(DomainDotification message)
        {
           _notifications.Add(message); 
        }

        public bool HasNotifications()
        {
            return _notifications.Any();
        }

        public List<DomainDotification> GetNotifications()
        {
            return _notifications;
        }

        public void Dispose()
        {
            _notifications = new List<DomainDotification>();
        }
    }
}
