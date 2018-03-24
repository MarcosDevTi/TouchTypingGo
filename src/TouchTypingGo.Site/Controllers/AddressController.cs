using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            IDomainNotificationHandler<DomainDotification> notifications, IUser user) : base(notifications, user)
        {
            _addressAppService = addressAppService;
        }
        // GET: Address
        public ActionResult Index()
        {
            return View(_addressAppService.GetAll());
        }

        // GET: Address/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressViewModel address)
        {
            if (!ModelState.IsValid) return View(address);
            _addressAppService.Add(address);

            ViewBag.SuccessCreated = ValidOperation() ? $"success,Endereço criado com sucesso." : "error,O endereço não foi refistrado, verifique as mensagens";

            return View(address);
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Address/Edit/5
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

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Address/Delete/5
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