using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _NavbarPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			
			return View();
		}
	}
}
