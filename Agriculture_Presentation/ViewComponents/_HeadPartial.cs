using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _HeadPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
