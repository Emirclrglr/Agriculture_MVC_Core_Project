﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents
{
	public class _TopAddressPartial:ViewComponent
	{
		private readonly IAddressService _addressService;

		public _TopAddressPartial(IAddressService addressService)
		{
			_addressService = addressService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _addressService.TGetListAll();
			return View(values);
		}
	}
}
