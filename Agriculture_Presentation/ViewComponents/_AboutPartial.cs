using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _AboutPartial:ViewComponent
	{
		IAboutService _aboutService;

		public _AboutPartial(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _aboutService.TGetListAll();
			return View(values);
		}
	}
}
