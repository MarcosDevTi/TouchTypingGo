using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Notifications;
using TouchTypingGo.Domain.Interfaces;

namespace TouchTypingGo.Site.Controllers
{
    public class LeconPresentationController : BaseController
    {
        private readonly ILeconPresentationAppService _leconPresentationAppService;

        public LeconPresentationController(ILeconPresentationAppService leconPresentationAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user) : base(notification, user)
        {
            _leconPresentationAppService = leconPresentationAppService;
        }
        // GET: LeconPresentation
        public ActionResult Index()
        {

            return View(_leconPresentationAppService.GetAll());
        }

        // GET: LeconPresentation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LeconPresentation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeconPresentation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LeconPresentationViewModel leconPresentationViewModel)
        {
            if (!ModelState.IsValid) return View(leconPresentationViewModel);
            _leconPresentationAppService.Add(leconPresentationViewModel);

            ViewBag.SuccessCreated = ValidOperation() ? "success,Exercício criado com sucesso!" : "error,O Exercício não foi refistrado, verifique as mensagens";
            return View(leconPresentationViewModel);
        }

        // GET: LeconPresentation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LeconPresentation/Edit/5
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

        // GET: LeconPresentation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeconPresentation/Delete/5
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
    }
}