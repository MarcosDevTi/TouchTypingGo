using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class StudentController : BaseController
    {
        private readonly IStudentAppService _studentAppService;

        public StudentController(
            IStudentAppService studentAppService,
            IDomainNotificationHandler<DomainDotification> notifications,
            IUser user,
            IStringLocalizer<BaseController> localizer) : base(notifications, user, localizer)
        {
            _studentAppService = studentAppService;
        }
        [Route("students")]
        public IActionResult Index()
        {
            return View(_studentAppService.GetAll());
        }

        [Route("new-student")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken, Route("new-student")]
        public IActionResult Create(StudentViewModel studentViewModel)
        {
            if (!ModelState.IsValid) return View(studentViewModel);
            _studentAppService.Add(studentViewModel);

            ViewBag.SuccessCreated = GetMessageCreate(studentViewModel);

            return View(studentViewModel);
        }
    }
}