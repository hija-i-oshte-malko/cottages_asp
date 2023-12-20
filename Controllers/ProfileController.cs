using Microsoft.AspNetCore.Mvc;

namespace cottages_asp.Controllers;

public class ProfileController : Controller
{
	public IActionResult Index()
	{
		return this.View();
	}
}
