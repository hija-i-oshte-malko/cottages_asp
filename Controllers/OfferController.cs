// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using cottages_asp.Data;
using cottages_asp.Models.Domein;
using cottages_asp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
	public async Task<IActionResult> Add(AddOfferViewModel model)
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
}
