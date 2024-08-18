using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents.Dashboard
{
    public class _DashboardChartPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = 88;
            ViewBag.v2 = 93;
            return View();
        }
    }
    
}
