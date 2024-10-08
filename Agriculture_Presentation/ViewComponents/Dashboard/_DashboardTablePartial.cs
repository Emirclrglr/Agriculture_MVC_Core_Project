﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents.Dashboard
{
    public class _DashboardTablePartial : ViewComponent
    {
        private readonly IContactService _contactService;

        public _DashboardTablePartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.TGetListAll();
            return View(values);
        }
    }
    
}
