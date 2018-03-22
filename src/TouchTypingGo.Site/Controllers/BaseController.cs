using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class BaseController : Controller
    {
        private readonly IDomainNotificationHandler<DomainDotification> _notification;
        protected readonly IUser _user;
       public Guid? StudentId { get; set; }
        public Guid? TeacherId { get; set; }
        public BaseController(IDomainNotificationHandler<DomainDotification> notification, IUser user)
        {
            _notification = notification;
            _user = user;

            if (_user.IsAuthenticated())
            {
                StudentId = _user.GetUderId();
                TeacherId = _user.GetUderId();
            }
        }

        protected bool ValidOperation()
        {
            return !_notification.HasNotifications();
        }
    }
}
