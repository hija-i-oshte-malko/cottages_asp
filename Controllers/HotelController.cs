using Microsoft.AspNetCore.Mvc;

namespace cottages_asp.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
