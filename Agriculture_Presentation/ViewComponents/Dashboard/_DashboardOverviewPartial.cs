using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents.Dashboard
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            var currentMonth = DateTime.Now.Month;
            ViewBag.TeamCount = c.Teams.Count();
            ViewBag.ServiceCount = c.Services.Count();
            ViewBag.MessageCount = c.Contacts.Count();
            ViewBag.CurrentMonthMessageCount = c.Contacts.Where(x => x.Date.Month == currentMonth).Count();

            ViewBag.ActiveAnnouncementCount = c.Announcements.Where(x => x.Status == true).Count();
            ViewBag.PassiveAnnouncementCount = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.v1 = c.Teams.Where(x => x.PersonTitle == "Satış/Pazarlama Müdürü").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.v2 = c.Teams.Where(x => x.PersonTitle == "Saha Ekibi Lideri").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.v3 = c.Teams.Where(x => x.PersonTitle == "Hasat Ekip Lideri").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.v4 = c.Teams.Where(x => x.PersonTitle == "Traktör Operatörü").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }

    }
}
