using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
	public class SocialMediaController : Controller
	{
		ISocialMediaService _socialMediaService;

		public SocialMediaController(ISocialMediaService socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}

		public IActionResult Sosyal_Medya()
		{
			var value = _socialMediaService.TGetListAll();
			return View(value);
		}

		public IActionResult DeleteSocialMedia(int id)
		{
			var value = _socialMediaService.TGetById(id);
			_socialMediaService.TDelete(value);
			return RedirectToAction("Sosyal_Medya");
		}

		[HttpGet]
		public IActionResult AddSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddSocialMedia(SocialMedia p)
		{
			_socialMediaService.TAdd(p);
			return RedirectToAction("Sosyal_Medya");
		}

		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var values = _socialMediaService.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia p)
		{
			_socialMediaService.TUpdate(p);
			return RedirectToAction("Sosyal_Medya");
		}
	}
}
