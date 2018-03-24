using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class InstitutionController : BaseController
    {
        private readonly IInstitutionAppService _institutionAppService;

        public InstitutionController(
            IInstitutionAppService institutionAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user) : base(notification, user)
        {
            _institutionAppService = institutionAppService;
        }
        // GET: Institution
        public ActionResult Index()
        {
            return View(_institutionAppService.GetAll());
        }

        // GET: Institution/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Institution/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InstitutionViewModel institution)
        {
            if (!ModelState.IsValid) return View(institution);
            _institutionAppService.Add(institution);

            ViewBag.SuccessCreated = ValidOperation() ? "success,Instituição criada com sucesso!" : "error,A Instituição não foi refistrado, verifique as mensagens";
            return View(institution);
        }

        // GET: Institution/Edit/5
        public ActionResult Edit(Guid id)
        {
            var institution = _institutionAppService.GetByIdWithAddress(id);
            return View(institution);
        }

        // POST: Institution/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InstitutionViewModel institution)
        {
            if (!ModelState.IsValid) return View(institution);
            _institutionAppService.Update(institution);

            return View(institution);

        }

        // GET: Institution/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Institution/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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

        public ActionResult UpdateAddress(AddressViewModel addressViewModel)
        {
            return View();
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