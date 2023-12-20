using Microsoft.AspNetCore.Mvc;
using cotagges_asp.Data;
using Microsoft.EntityFrameworkCore;
using cottages_asp.Models.Entities;
using cottages_asp.Models;

namespace cottages_asp.Controllers
{
	public class BuildingController : Controller
	{
		private readonly CottagesDbContext context;
		public BuildingController(CottagesDbContext context)
		{
			this.context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddBuildingViewModel model)
		{
			var building = new Building()
			{
				BuildingId = Guid.NewGuid(),
				Location = model.Location,
				Name = model.Name,
				Description = model.Description,
				Review = model.Review,


			};
			await context.Buildings.AddAsync(building);
			await context.SaveChangesAsync();
			return RedirectToAction("Index");

		}
		[HttpGet]
		public async Task<IActionResult> Update(Guid id)
		{

			var building = await context.Buildings.FirstOrDefaultAsync(x => x.BuildingId == id);
			if (building != null)

			{
				var viewModel = new UpdateBuildingViewModel()
				{
					BuildingId = building.BuildingId,
					Location = building.Location,
					Name = building.Name,
					Description = building.Description,
					Review = building.Review,

				};

				return await Task.Run(() => View("Update", viewModel));

			}
			return RedirectToAction("Index");


		}


		[HttpPost]
		public async Task<IActionResult> Update(UpdateBuildingViewModel model)
		{

			var building = await context.Buildings.FindAsync(model.BuildingId);
			if (building != null)

			{
				building.BuildingId = model.BuildingId;
				building.Location = model.Location;
				building.Name = model.Name;
				building.Description = model.Description;
				building.Review = model.Review;




				await context.SaveChangesAsync();
				return RedirectToAction("Index");
			}
			return RedirectToAction("Index");

		}

		[HttpGet]
		public async Task<IActionResult> Delete(Guid id)
		{

			var building = await context.Buildings.FirstOrDefaultAsync(x => x.BuildingId == id);
			if (building != null)

			{
				var viewModel = new DeleteBuidlingViewModel()
				{
					BuildingId = building.BuildingId,
					Location = building.Location,
					Name = building.Name,
					Description = building.Description,
					Review = building.Review,
				};

				return await Task.Run(() => View("Delete", viewModel));

			}
			return RedirectToAction("Index");



		}


		[HttpPost]

		public async Task<IActionResult> Delete(DeleteBuidlingViewModel model)
		{
			var building = await context.Buildings.FindAsync(model.BuildingId);
			if (building != null)
			{
				context.Buildings.Remove(building);
				await context.SaveChangesAsync();
				return RedirectToAction("Index");

			}
			return RedirectToAction("Index");
		}


	}


}

