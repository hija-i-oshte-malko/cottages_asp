using cotagges_asp.Data;
using cottages_asp.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace cottages_asp.Controllers
{
    public class HotelController : Controller
    {
		public CottagesDbContext context { get; set; }
		public HotelController(CottagesDbContext con) {
			this.context = con;
		}
        public IActionResult Index()
        {
			Building building = new Building()
			{
				Id = new Guid("dd6d9cf2-c228-4deb-bdbd-03acf07d3e5b"),
				Name = "Hotel1",
				Description = "Desc1",
				Review = 4,
				Location = "Locat"
			};
			ViewBag.ImageUrls = context.BuildingImages.Where(x=>x.BuildingId== building.Id).ToList();
			return View(building);
		}
	}
}
