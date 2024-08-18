using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _GalleryPartial:ViewComponent
	{
		IGalleryService _galleryService;

		public _GalleryPartial(IGalleryService galleryService)
		{
			_galleryService = galleryService;
		}

		public IViewComponentResult Invoke()
		{
			List<Gallery> values = _galleryService.TGetListAll();
			return View(values);
		}
	}
}
