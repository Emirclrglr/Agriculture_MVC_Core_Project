using BusinessLayer.Abstract;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
    public class AddressController : Controller
    {
        IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Adres()
        {
            var value = _addressService.TGetListAll();
            return View(value);
        }

        public IActionResult DeleteAddress(int id)
        {
            var value = _addressService.TGetById(id);
            _addressService.TDelete(value);
            return RedirectToAction("Adres");
        }

        [HttpGet]
        public IActionResult UpdateAddress(int id)
        {
            var value = _addressService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAddress(Address p)
        {
            _addressService.TUpdate(p);
            return RedirectToAction("Adres");
        }
    }
}
