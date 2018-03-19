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
    public class LeconResultController : BaseController
    {
        private readonly ILeconResultAppService _leconResultAppService;
        private readonly ILeconPresentationAppService _leconPresentationAppService;
        public LeconResultController(
            ILeconResultAppService leconResultAppService,
            ILeconPresentationAppService leconPresentationAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user) : base(notification, user)
        {
            _leconResultAppService = leconResultAppService;
            _leconPresentationAppService = leconPresentationAppService;
        }

        // GET: LeconResult
        public ActionResult Index()
        {
            return View(_leconResultAppService.GetAll());
        }

        // GET: LeconResult/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LeconResult/Create
        public ActionResult Create()
        {
            ViewBag.LeconPresentations = _leconResultAppService.LeconsPresentationsSelect();
            return View();
        }

        // POST: LeconResult/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LeconResultViewModel leconResult)
        {
            if (!ModelState.IsValid) return View(leconResult);
            _leconResultAppService.Add(leconResult);

            ViewBag.SuccessCreated = ValidOperation() ? "success,Resultado do Exercício criado com sucesso!" : "error,O Resultado do Exercício não foi refistrado, verifique as mensagens";
            return View(leconResult);
        }

        // GET: LeconResult/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LeconResult/Edit/5
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

        // GET: LeconResult/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeconResult/Delete/5
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