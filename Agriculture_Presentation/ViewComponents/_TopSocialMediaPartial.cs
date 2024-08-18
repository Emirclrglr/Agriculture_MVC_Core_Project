using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _TopSocialMediaPartial : ViewComponent
	{
		ISocialMediaService _socialMediaService;

		public _TopSocialMediaPartial(ISocialMediaService socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}

		public IViewComponentResult Invoke()
		{		
			var values = _socialMediaService.TGetListAll();
			return View(values);
		}
	}
}
