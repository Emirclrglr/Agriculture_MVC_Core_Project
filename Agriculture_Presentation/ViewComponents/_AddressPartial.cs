using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _AddressPartial:ViewComponent
	{
		IAddressService _addressService;

		public _AddressPartial(IAddressService addressService)
		{
			_addressService = addressService;
		}

		public IViewComponentResult Invoke()
		{
			List<Address> values = _addressService.TGetListAll();
			return View(values);
		}
	}
}
