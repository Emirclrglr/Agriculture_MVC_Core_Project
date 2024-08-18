using Agriculture_Presentation.Models;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
    public class ServiceController : Controller
    {
        IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        // Verileri listeleme
        public IActionResult Hizmetler()
        {
            var values = _serviceService.TGetListAll();
            return View(values);
        }

        // Yeni hizmet ekle
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _serviceService.TAdd(new Service()
                {
                    ServiceTitle = model.Title,
                    ClientImage = model.ImageUrl,
                    ServiceDescription = model.Description
                });

                return RedirectToAction("Hizmetler");

            }
            return View(model);
        }

        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetById(id);
            _serviceService.TDelete(values);
            return RedirectToAction("Hizmetler");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _serviceService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return RedirectToAction("Hizmetler");
        }

        
    }
}
