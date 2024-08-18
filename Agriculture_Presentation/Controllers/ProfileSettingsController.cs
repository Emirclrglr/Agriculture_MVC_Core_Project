using Agriculture_Presentation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
    public class ProfileSettingsController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileSettingsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.Mail = values.Email;
            model.PhoneNumber = values.PhoneNumber;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserUpdateViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Email = p.Mail;
            user.PhoneNumber = p.PhoneNumber;
            if (p.Password == p.ConfirmPassword)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            }

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }
    }
}
