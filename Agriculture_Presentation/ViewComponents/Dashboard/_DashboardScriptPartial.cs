using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.ViewComponents.Dashboard
{
    public class _DashboardScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
    
}
