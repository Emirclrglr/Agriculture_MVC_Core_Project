using BusinessLayer.Abstract;
using BusinessLayer.FluentValidation;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Agriculture_Presentation.Controllers
{
    public class GalleryController : Controller
    {
        IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IActionResult Galeri()
        {
            var value = _galleryService.TGetListAll();
            return View(value);
        }

        public IActionResult DeleteGallery(int id)
        {
            var value = _galleryService.TGetById(id);
            _galleryService.TDelete(value);
            return RedirectToAction("Galeri");
        }

        [HttpGet]
        public IActionResult AddGallery()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGallery(Gallery p)
        {
            GalleryValidator validationRules = new GalleryValidator();
            ValidationResult result = validationRules.Validate(p);

            if (result.IsValid)
            {
                _galleryService.TAdd(p);
                return RedirectToAction("Galeri");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateGallery(int id)
        {
            var value = _galleryService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateGallery(Gallery p)
        {
            GalleryValidator validationRules = new GalleryValidator();
            ValidationResult result = validationRules.Validate(p);

            if (result.IsValid)
            {
                _galleryService.TUpdate(p);
                return RedirectToAction("Galeri");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
