using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityExample.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityExample.Controllers
{
    public class HomeController : Controller
    {

		#region Dependency Injection
		private readonly RoleManager<IdentityRole> _roleManager;

		private readonly UserManager<IdentityUser> _identityUser;

		public HomeController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> identityUser)
		{
			_roleManager = roleManager;
			_identityUser = identityUser;
		}
		#endregion

		public async Task<IActionResult> Index()
        {
			var model = new CurrentLoggedDataViewModel();

			if (User.Identity.IsAuthenticated)
			{
				var identityUser = _identityUser.Users.SingleOrDefault(q => q.UserName == User.Identity.Name);
				var roles = await _identityUser.GetRolesAsync(identityUser);

				model = new CurrentLoggedDataViewModel
				{
					UserName = User.Identity.Name,
					RoleNames = roles.ToArray()
				};
			}

			return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
