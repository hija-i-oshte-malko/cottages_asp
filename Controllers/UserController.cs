using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cottages_asp.Controllers
{
    public class UserController : Controller
    {
		[HttpGet]
        public IActionResult Login()
        {
            return this.View();
        }

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}
	}
}
