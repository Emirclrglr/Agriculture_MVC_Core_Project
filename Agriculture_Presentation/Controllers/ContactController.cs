using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Mesajlar()
        {
            var value = _contactService.TGetListAll();
            return View(value);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return RedirectToAction("Mesajlar");
        }

        public IActionResult ViewMessage(int id)
        {
            var value = _contactService.TGetById(id);
            return View(value);
        }

    }
}
