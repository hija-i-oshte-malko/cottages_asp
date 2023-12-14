

using cottages_asp.Models.Entities;
using cottages_asp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cottages_asp.Data;

namespace cottages_asp.Controllers;
public class OfferController : Controller
{
	private readonly CottagesDbContext _context;
	public OfferController(CottagesDbContext context)
	{
		this._context = context;
	}

	[HttpGet]
	public async Task<IActionResult> Add()
	{
		List<Offer> offer = await _context.Offers.ToListAsync();
		ViewBag.BuildingsOptionList = new SelectList(_context.Buildings, "Id", "Name");
		ViewBag.RoomsOptionList = new SelectList(_context.Rooms, "Id", "Name");
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Add(AddBuildingViewModel model)
	{
		var offer = new Offer()
		{
			BuildingId = _context.Buildings.Where(x => x.BuildingId == model.BuildingId).FirstOrDefault().BuildingId,
			Building = _context.Buildings.Where(x => x.BuildingId == model.BuildingId).FirstOrDefault()
		};
		await _context.Offers.AddAsync(offer);
		await _context.SaveChangesAsync();
		return RedirectToAction("Index");
	
	}
	[HttpGet]
	public async Task<IActionResult> Update(Guid id)
	{

		var offer = await _context.Offers.FirstOrDefaultAsync(x => x.OfferId == id);
		if (offer != null)

		{
			var viewModel = new UpdateBuildingViewModel()
			{
				BuildingId = offer.BuildingId,

			};

			return await Task.Run(() => View("Update", viewModel));

		}
		return RedirectToAction("Index");


	}


	[HttpPost]
	public async Task<IActionResult> Update(UpdateOfferViewModel model)
	{

		var offer = await _context.Offers.FindAsync(model.BuildingId);
		if (offer != null)

		{
			offer.BuildingId = model.BuildingId;
			offer.OfferId = model.OfferId;
		}
		await _context.SaveChangesAsync();
		return RedirectToAction("Index");

	}

	[HttpGet]
	public async Task<IActionResult> Delete(Guid id)
	{
		var snake = await _context.Offers.FindAsync(id);
		if (snake is null)
		{
			return await Task.Run(() => NotFound());
		}

		_context.Offers.Remove(snake);
		await _context.SaveChangesAsync();
		return await Task.Run(() => RedirectToAction("All"));
	}
}
