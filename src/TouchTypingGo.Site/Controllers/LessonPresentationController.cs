using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class LessonPresentationController : BaseController
    {
        private readonly ILessonPresentationAppService _lessonPresentationAppService;

        public LessonPresentationController(
            ILessonPresentationAppService lessonPresentationAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user,
            IStringLocalizer<BaseController> localizer) : base(notification, user, localizer)
        {
            _lessonPresentationAppService = lessonPresentationAppService;
        }
        [Route("lessons-presentations")]
        public IActionResult Index()
        {
            return View(_lessonPresentationAppService.GetAll());
        }

        [Route("new-lesson-presentation")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken, Route("new-lesson-presentation")]
        public IActionResult Create(LessonPresentationViewModel lessonPresentationViewModel)
        {
            if (!ModelState.IsValid) return View(lessonPresentationViewModel);
            _lessonPresentationAppService.Add(lessonPresentationViewModel);

            ViewBag.SuccessCreated = GetMessageCreate(lessonPresentationViewModel);
            return View(lessonPresentationViewModel);
        }
    }
}