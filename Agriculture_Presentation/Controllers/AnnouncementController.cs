using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
    public class AnnouncementController : Controller
    {
        IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Duyurular()
        {
            var value = _announcementService.TGetListAll();
            return View(value);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetById(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Duyurular");
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement p) 
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = false;
            _announcementService.TAdd(p);
            return RedirectToAction("Duyurular");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _announcementService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(Announcement p)
        {
            _announcementService.TUpdate(p);
            return RedirectToAction("Duyurular");
        }

        public IActionResult AnnouncementStatusToTrue(int id)
        {
            _announcementService.TAnnouncementStatusToTrue(id);
            return RedirectToAction("Duyurular");
        }

        public IActionResult AnnouncementStatusToFalse(int id)
        {
            _announcementService.TAnnouncementStatusToFalse(id);
            return RedirectToAction("Duyurular");
        }
    }
}
