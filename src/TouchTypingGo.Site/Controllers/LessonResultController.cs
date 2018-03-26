using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class LessonResultController : BaseController
    {
        private readonly IlessonResultAppService _lessonResultAppService;

        public LessonResultController(
            IlessonResultAppService lessonResultAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user,
            IStringLocalizer<BaseController> localizer) : base(notification, user, localizer)
        {
            _lessonResultAppService = lessonResultAppService;
        }

        public IActionResult Index()
        {
            return View(_lessonResultAppService.GetAll());
        }

        public IActionResult Create()
        {
            ViewBag.lessonPresentations = _lessonResultAppService.lessonsPresentationsSelect();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LessonResultViewModel lessonResult)
        {
            if (!ModelState.IsValid) return View(lessonResult);
            _lessonResultAppService.Add(lessonResult);

            ViewBag.SuccessCreated = GetMessageCreate(lessonResult);
            return View(lessonResult);
        }
    }
}