using Microsoft.AspNetCore.Mvc;

namespace cottages_asp.Controllers
{
	public class SearchController : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			return View();
		}
	}
}
