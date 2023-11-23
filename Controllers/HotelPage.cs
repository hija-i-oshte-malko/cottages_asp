using Microsoft.AspNetCore.Mvc;

namespace cottages_asp.Controllers
{
    public class HotelPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
