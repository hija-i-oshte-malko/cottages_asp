using Microsoft.AspNetCore.Mvc;
using cottages_asp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cotagges_asp.Data;
using cottages_asp.Models.Entities;

namespace cottages_asp.Controllers;

public class SearchController : Controller
{
	public CottagesDbContext _context;

	public SearchController(CottagesDbContext context)
	{
		_context = context;
	}
	[HttpGet]
	public async Task<IActionResult> Index(BuildingViewModel buildingViewModel)
	{
		List<Building> buildings = await _context.Buildings.ToListAsync();
		ViewBag.OfferOptionList = new SelectList(_context.Offers, "Id", "Name");
		return this.View();
	}
}
