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
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Site.Controllers
{
    public class KeyboardController : BaseController
    {
        private readonly IKeyboardAppService _keyboardAppService;

        public KeyboardController(IKeyboardAppService keyboardAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user) : base(notification, user)
        {
            _keyboardAppService = keyboardAppService;
        }
        public ActionResult Index()
        {
            return View(_keyboardAppService.GetAll());
        }

        // GET: Keyboard/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_keyboardAppService.GetById(id));
        }

        // GET: Keyboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Keyboard/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KeyboardViewModel keyboardViewModel)
        {
            if (!ModelState.IsValid) return View(keyboardViewModel);
            _keyboardAppService.Add(keyboardViewModel);

            ViewBag.SuccessCreated = ValidOperation() ? "success,Teclado criado com sucesso!" : "error,O Teclado não foi refistrado, verifique as mensagens";

            return View((keyboardViewModel));
        }

        // GET: Keyboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Keyboard/Edit/5
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

        // GET: Keyboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Keyboard/Delete/5
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