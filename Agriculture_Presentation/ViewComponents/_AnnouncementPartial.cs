using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _AnnouncementPartial:ViewComponent
	{
		IAnnouncementService _announcementService;

		public _AnnouncementPartial(IAnnouncementService announcementService)
		{
			_announcementService = announcementService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _announcementService.GetListOnlyTrue();
			return View(values);
		}
	}
}
