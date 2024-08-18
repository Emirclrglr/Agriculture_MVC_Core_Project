using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents.Dashboard
{
    public class _DashboardNavbarPartial:ViewComponent
    {

		public IViewComponentResult Invoke()
        {
			using var c = new Context();
			var user = User.Identity.Name;
			var userName = c.Users.Where(x => x.UserName == user).Select(y => y.UserName).FirstOrDefault();
			ViewBag.UserName = userName;
			return View();
        }

	

	}
}
