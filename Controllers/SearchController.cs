using Microsoft.AspNetCore.Mvc;

namespace Hija.Controllers
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
