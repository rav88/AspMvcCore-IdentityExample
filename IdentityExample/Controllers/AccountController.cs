using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityExample.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityExample.Controllers
{
    public class AccountController : Controller
    {
	    private readonly UserManager<IdentityUser> _userManager;

	    private readonly SignInManager<IdentityUser> _signInManager;

	    public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
	    {
		    _userManager = userManager;
			_signInManager = signInManager;
	    }

	    public IActionResult Login()
		{
			return View();
		}

	    public IActionResult Register()
	    {
		    return View();
	    }

		[HttpPost]
	    public async Task<IActionResult> Register(RegisterViewModel model)
	    {
		    if (ModelState.IsValid)
		    {
			    var identity = new IdentityUser(model.Login) {Email = model.Email};

			    var result = await _signInManager.UserManager.CreateAsync(identity, model.Password);

				if (result.Succeeded)
			    {
				    return RedirectToAction("Index", "Home");
				}

			    foreach (var error in result.Errors)
			    {
					ModelState.AddModelError("", error.Description);
			    }
		    }

		    return View(model);
	    }
	}
}