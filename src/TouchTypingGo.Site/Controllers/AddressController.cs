using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Core.Interfaces;
using TouchTypingGo.Domain.Core.Notifications;

namespace TouchTypingGo.Site.Controllers
{
    public class AddressController : BaseController
    {
        private readonly IAddressAppService _addressAppService;


        public AddressController(IAddressAppService addressAppService,
            IDomainNotificationHandler<DomainDotification> notifications, IUser user,
            IStringLocalizer<BaseController> localizer) : base(notifications, user, localizer)
        {
            _addressAppService = addressAppService;
        }
        public IActionResult Index()
        {
            return View(_addressAppService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddressViewModel address)
        {
            if (!ModelState.IsValid) return View(address);
            _addressAppService.Add(address);

            ViewBag.SuccessCreated = GetMessageCreate(address);

            return View(address);
        }
    }
}