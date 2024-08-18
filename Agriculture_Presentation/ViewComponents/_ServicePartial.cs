using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _ServicePartial:ViewComponent
	{
		IServiceService serviceService;

		public _ServicePartial(IServiceService serviceService)
		{
			this.serviceService = serviceService;
		}

		public IViewComponentResult Invoke()
		{
			List<Service> values = serviceService.TGetListAll();
			return View(values);
		}
	}
}
