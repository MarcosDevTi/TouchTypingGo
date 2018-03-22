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
    public class TeacherController : BaseController
    {
        private readonly ITeacherAppService _teacherAppService;

        public TeacherController(ITeacherAppService teacherAppService,
            IDomainNotificationHandler<DomainDotification> notifications,
            IUser user) : base(notifications, user)
        {
            _teacherAppService = teacherAppService;
        }

        public ActionResult Index()
        {
            return View(_teacherAppService.GetAll());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeacherViewModel teacherViewModel)
        {
            if (!ModelState.IsValid) return View(teacherViewModel);
            _teacherAppService.Add(teacherViewModel);

            ViewBag.SuccessCreated = ValidOperation() ? "success,Professor criado com sucesso!" : "error,O professor não foi refistrado, verifique as mensagens";
            return View(teacherViewModel);
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var teacherViewModel = _teacherAppService.GetById(id.Value);
           
            return View(teacherViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
           _teacherAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}