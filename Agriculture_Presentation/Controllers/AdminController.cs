using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
	public class AdminController : Controller
	{
		IAdminService _adminService;

		public AdminController(IAdminService adminService)
		{
			_adminService = adminService;
		}
		public IActionResult Index()
		{
			var values = _adminService.TGetListAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddAdmin()
		{
			return View();
		}
		[HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
			_adminService.TAdd(admin);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
			var value = _adminService.TGetById(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAdmin(Admin admin)
        {
            _adminService.TUpdate(admin);
            return RedirectToAction("Index");
        }
    }
}
