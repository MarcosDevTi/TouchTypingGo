using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class InstitutionController : BaseController
    {
        private readonly IInstitutionAppService _institutionAppService;
        private readonly IStringLocalizer<BaseController> _localizer;

        public InstitutionController(
            IInstitutionAppService institutionAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user,
            IStringLocalizer<BaseController> localizer) : base(notification, user, localizer)
        {
            _institutionAppService = institutionAppService;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            return View(_institutionAppService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(InstitutionViewModel institution)
        {


            if (!ModelState.IsValid) return View(institution);
            _institutionAppService.Add(institution);
            GetMessageCreate(institution);

            ViewBag.SuccessCreated = GetMessageCreate(institution);
            return View(institution);
        }

        public IActionResult Edit(Guid id)
        {
            var institution = _institutionAppService.GetByIdWithAddress(id);
            return View(institution);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(InstitutionViewModel institution)
        {
            if (!ModelState.IsValid) return View(institution);
            _institutionAppService.Update(institution);

            return View(institution);

        }

        public IActionResult AddAddress(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressViewModel = _institutionAppService.GetByIdWithAddress(id.Value);
            return PartialView("_AddAddress", addressViewModel);
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var institution = _institutionAppService.GetById(id.Value);

            return PartialView(institution);
        }
    }
}