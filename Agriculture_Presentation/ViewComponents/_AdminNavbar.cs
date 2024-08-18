using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
    public class _AdminNavbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            var user = User.Identity.Name;
            var userName = c.Users.Where(x=>x.UserName == user).Select(y=>y.UserName).FirstOrDefault();
            ViewBag.Username = userName;
            return View();  
        }
    }
}
