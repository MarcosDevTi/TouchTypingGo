using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class LessonListController : BaseController
    {
        private readonly ILessonListAppService _lessonListAppService;
        private readonly ILessonPresentationAppService _lessonPresentationAppService;

        public LessonListController(
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user,
            ILessonListAppService lessonListAppService, ILessonPresentationAppService lessonPresentationAppService,
            IStringLocalizer<BaseController> localizer) : base(notification, user, localizer)
        {
            _lessonListAppService = lessonListAppService;
            _lessonPresentationAppService = lessonPresentationAppService;
        }

        public IActionResult App(Guid lessonId)
        {
            var lesson = _lessonPresentationAppService.GetById(lessonId);
            return View(lesson);
        }

        public IActionResult Index()
        {
            return View(_lessonListAppService.PreviewLessonViewModels());
        }

        public IActionResult Lesson(Guid id)
        {

            return View(_lessonListAppService.GetById(id));
        }
    }
}