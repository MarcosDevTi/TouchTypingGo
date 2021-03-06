﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class KeyboardController : BaseController
    {
        private readonly IKeyboardAppService _keyboardAppService;

        public KeyboardController(IKeyboardAppService keyboardAppService,
            IDomainNotificationHandler<DomainDotification> notification,
            IUser user,
            IStringLocalizer<BaseController> localizer) : base(notification, user, localizer)
        {
            _keyboardAppService = keyboardAppService;
        }

        [Route("keyboards")]
        public IActionResult Index()
        {
            return View(_keyboardAppService.GetAll());
        }

        [Route("keyboard-details")]
        public IActionResult Details(Guid id)
        {
            return View(_keyboardAppService.GetById(id));
        }

        [Route("create-keyboard")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken, Route("create-keyboard")]
        public IActionResult Create(KeyboardViewModel keyboardViewModel)
        {
            if (!ModelState.IsValid) return View(keyboardViewModel);
            _keyboardAppService.Add(keyboardViewModel);

            ViewBag.SuccessCreated = GetMessageCreate(keyboardViewModel);

            return View((keyboardViewModel));
        }

    }
}