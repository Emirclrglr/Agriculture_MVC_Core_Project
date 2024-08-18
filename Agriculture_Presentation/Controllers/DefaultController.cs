using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        IContactService _contactService;

		public DefaultController(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
		[HttpPost]
		public IActionResult SendMessage(Contact contact)
		{
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.TAdd(contact);
			return RedirectToAction("Index","Default");
		}
	}
}
