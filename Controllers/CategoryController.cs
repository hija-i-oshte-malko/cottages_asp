using cottages_asp.Models;
using Microsoft.AspNetCore.Mvc;
using cottages_asp.Data;
using Microsoft.EntityFrameworkCore;
using cottages_asp.Models.Entities;
using cottages_asp.Models;

namespace cottages_asp.Controllers;
public class CategoryController : Controller
{
	private readonly CottagesDbContext _context;
	public CategoryController(CottagesDbContext context)
	{
		this._context = context;
	}

	public IActionResult Index()
	{
		var category = _context.Categories.ToList();
		return View(category);
	}

	[HttpGet]
	public IActionResult Add()
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Add(AddCategoryViewModel model)
	{
		var category = new Category()
		{
			CategoryId = Guid.NewGuid(),
			Name = model.Name,
			Icon = model.Icon,

		};
		await _context.Categories.AddAsync(category);
		await _context.SaveChangesAsync();
		return RedirectToAction("Index");

	}
	[HttpGet]
	public async Task<IActionResult> Update(Guid id)
	{

		var category = _context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
		if (category != null)

		{
			var viewModel = new UpdateCategoryViewModel()
			{
				CategoryId = category.CategoryId,
				Name = category.Name,
				Icon = category.Icon,

			};

			return await Task.Run(() => View("Update", viewModel));

		}
		return RedirectToAction("Index");


	}


	[HttpPost]
	public async Task<IActionResult> Update(UpdateCategoryViewModel model)
	{

		var category = await _context.Categories.FindAsync(model.CategoryId);
		if (category != null)

		{
			category.CategoryId = model.CategoryId;
			category.Name = model.Name;
			category.Icon = model.Icon;
			



			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		return RedirectToAction("Index");

	}

	[HttpGet]
	public async Task<IActionResult> Delete(Guid id)
	{

		var category = _context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
		if (category != null)

		{
			var viewModel = new DeleteCategoryViewModel()
			{
				CategoryId = category.CategoryId,
				Name = category.Name,
				Icon = category.Icon,
				
			};

			return await Task.Run(() => View("Delete", viewModel));

		}
		return RedirectToAction("Index");



	}


	[HttpPost]

	public async Task<IActionResult> Delete(DeleteCategoryViewModel model)
	{
		var category = await _context.Categories.FindAsync(model.CategoryId);
		if (category != null)
		{
			_context.Categories.Remove(category);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");

		}
		return RedirectToAction("Index");
	}


}




