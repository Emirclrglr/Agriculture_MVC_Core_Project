using Agriculture_Presentation.Models;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture_Presentation.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly SignInManager<IdentityUser> _signInManager;

		public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SignIn(UserLoginViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, false, false);
				if (result.Succeeded)
				{
					return RedirectToAction("Index","Dashboard");
				}
				else
				{
					return RedirectToAction("SignIn");
				}
			}
			return View();
			
		}

		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p)
        {
			IdentityUser user = new IdentityUser()
			{
				
				UserName = p.Username,
				Email = p.Mail
			};

			if (p.Password == p.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(user, p.Password);
				if (result.Succeeded)
				{
					return RedirectToAction("Index");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}

            return View(p);
        }

		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("SignIn");
		}
    }
}
