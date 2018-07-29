using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityExample.Controllers
{
	[Authorize]
	public class RoleController : Controller
    {
		private readonly RoleManager<IdentityRole> _roleManager;

		public RoleController(RoleManager<IdentityRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public IActionResult Index()
        {
            return View();
        }
    }
}