using BusinessLayer.Abstract;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
    public class TeamController : Controller
    {
        ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Personeller()
        {
            var value = _teamService.TGetListAll();
            return View(value);
        }

        public IActionResult DeletePerson(int id)
        {
            var value = _teamService.TGetById(id);
            _teamService.TDelete(value);
            return RedirectToAction("Personeller");
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Team p)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult result = validationRules.Validate(p);

            if (result.IsValid)
            {
                _teamService.TAdd(p);
                return RedirectToAction("Personeller");
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
        public IActionResult UpdatePerson(int id)
        {
            var value = _teamService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePerson(Team p)
        {
            TeamValidator validationRules = new TeamValidator();
            ValidationResult result = validationRules.Validate(p);

            if (result.IsValid)
            {
                _teamService.TUpdate(p);
                return RedirectToAction("Personeller");
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
