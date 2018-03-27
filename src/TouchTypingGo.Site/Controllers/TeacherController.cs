using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class TeacherController : BaseController
    {
        private readonly ITeacherAppService _teacherAppService;

        public TeacherController(ITeacherAppService teacherAppService,
            IDomainNotificationHandler<DomainDotification> notifications,
            IUser user,
            IStringLocalizer<BaseController> localizer) : base(notifications, user, localizer)
        {
            _teacherAppService = teacherAppService;
        }

        [Route("teachers")]
        public IActionResult Index()
        {
            return View(_teacherAppService.GetAll());
        }

        [Route("new-teacher")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken, Route("new-teacher")]
        public IActionResult Create(TeacherViewModel teacherViewModel)
        {
            if (!ModelState.IsValid) return View(teacherViewModel);
            _teacherAppService.Add(teacherViewModel);

            ViewBag.SuccessCreated = GetMessageCreate(teacherViewModel);
            return View(teacherViewModel);
        }

        [Route("delete-teacher/{id:guid}")]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var teacherViewModel = _teacherAppService.GetById(id.Value);

            return View(teacherViewModel);
        }

        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken, Route("delete-teacher/{id:guid}")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _teacherAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}